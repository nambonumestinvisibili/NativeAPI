using AutoMapper;
using Azure.Core;
using Native.Domain.Models;
using Native.Repositories;
using Native.Service.DTOs;
using Native.Service.Security;
using Native.Service.Services.Cities;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Native.Service.Services
{
    internal class ResidenceService : ResourceService<Location>, IResidenceService
    {
        private readonly ICurrentUserProvider _currentUserProvider;

        public ResidenceService(IRepositoryManager repositoryManager, IMapper mapper, ICurrentUserProvider currentUserProvider) : base(repositoryManager, mapper)
        {
            _currentUserProvider = currentUserProvider;
        }

        public async Task<CityDTO> AssignNativeAddressToPersonBasedOn(double longitude, double latitude, bool isLocationNative)
        {
            var address = await GetAddressBasedOn(longitude, latitude);

            City city = new()
            {
                CityName = address.City,
                CountryIsoCode = address.ISO3166,
                PostalCode = address.Postcode,
            };

            var profile = (await _currentUserProvider.GetUserWithProfile()).Profile;
            var dbCity = await _repositoryManager.City.CreateIfDoesntExist(city);


            await _repositoryManager.Profile.AddCityToProfile(profile, dbCity, isProfileNativeToTheCity: true);
            await _repositoryManager.Save();

            return _mapper.Map<CityDTO>(dbCity);
        }

        public async Task<Address> GetAddressBasedOn(double longitude, double latitude)
        {
            const string apiUrl = "https://nominatim.openstreetmap.org/reverse";

            using (var httpClient = new HttpClient())
            {
                // Define the query parameters
                var queryParameters = new System.Collections.Generic.Dictionary<string, string>
            {
                { "format", "json" },
                { "lat", latitude.ToString() },
                { "lon", longitude.ToString() }
            };

                string fullUrl = $"{apiUrl}?{string.Join("&", queryParameters.Select(p => $"{p.Key}={p.Value}"))}";

                HttpRequestMessage httpRequestMessage = new()
                {
                    RequestUri = new Uri(fullUrl),
                    Method = HttpMethod.Get,
                };
                httpRequestMessage.Headers.Add("User-Agent", "Native/1.0 (Local Testing)");
                try
                {
                    var response = await httpClient.SendAsync(httpRequestMessage);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();

                        var options = new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                        };

                        var x = JsonSerializer.Deserialize<NominatimAddress>(responseContent, options);
                        Console.WriteLine(x);

                        return new Address(
                            City: x.Address.City,
                            State: x.Address.State,
                            Postcode: x.Address.Postcode,
                            Country: x.Address.Country,
                            CountryCode: x.Address.CountryCode,
                            ISO3166: x.Address.ISO3166
                            );
                    }
                    else
                    {
                        Console.WriteLine("Error: HTTP request failed with status code " + response.StatusCode);
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return null;
        }
    }
}
