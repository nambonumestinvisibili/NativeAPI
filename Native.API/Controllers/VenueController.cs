using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Native.Domain.Models;
using Native.Service.Services.Interfaces;
using Native.Services.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Controllers
{
    public class VenueController : NativeApiController
    {
        private readonly IVenueService _venueService;

        public VenueController(
            IMapper mapper,
            IVenueService venueService
        ) : base(mapper)
        {
            _venueService = venueService;
        }

        [HttpGet]
        public async Task<IEnumerable<Venue>> GetAll() =>
            await _venueService.GetAllAsync();

        [HttpGet("{guid}")]
        public async Task<Venue> GetVenue(Guid guid) =>
            await _venueService.GetByGuid(guid);

        [HttpPost]
        public async Task CreateVenue(CreateVenueRequest request)
        {
            var venue = _mapper.Map<Venue>(request);
            await _venueService.CreateNewVenue(venue, request.InterestGuids);
        }
    }
}
