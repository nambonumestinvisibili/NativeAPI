using LanguageExt;
using Microsoft.EntityFrameworkCore;
using Native.Domain.DataAccess;
using Native.Domain.Models;
using Native.Repositories.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Repositories.Repositories.Implementations
{
    internal class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(NativeContext context) : base(context)
        {
        }

        public async Task<City> CreateCityIfDoesntExist(City city)
        {
            var cityFromDb = await NativeContext.Cities.FirstOrDefaultAsync(e => 
                e.CountryIsoCode == city.CountryIsoCode
                && e.CityName == city.CityName);
            if (cityFromDb == null)
            {
                NativeContext.Cities.Add(city);
                await NativeContext.SaveChangesAsync();
                return city;
            }
            return cityFromDb;
        }

        public async Task VisitCityByProfileIfNotVisitedBefore(Profile profile, City city) 
        {
            if (!profile.HasProfileRegisteredNativeCity)
            {
                throw new ValidationException("Profile needs to have native city registered first");
            }

            var record = await NativeContext.ProfileCity.FirstOrDefaultAsync(pc =>
                pc.ProfileId == profile.Id && pc.CityId == city.Id);

            if (record != null)
            {
                return;
            }

            var pc = new ProfileCity()
            {
                Profile = profile,
                City = city,
                IsProfileNativeToTheCity = false
            };

            NativeContext.ProfileCity.Add(pc);
        }
    }
}
