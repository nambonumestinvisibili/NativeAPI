using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Native.Domain.Models;
using Native.Service.DTOs;
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
        public async Task<IEnumerable<VenueDTO>> GetAll() =>
            await _venueService.GetAllAsync<VenueDTO>();

        [HttpGet("{guid}")]
        public async Task<VenueDTO> GetVenue(Guid guid) =>
            await _venueService.GetByGuid<VenueDTO>(guid);

        [HttpPost]
        public async Task<IActionResult> CreateVenue(CreateVenueRequest request)
        {
            var venue = _mapper.Map<Venue>(request);
            await _venueService.CreateNewVenue(venue, request.InterestGuids);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
