﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Native.API.Requests;
using Native.Domain.Models;
using Native.Service.DTOs;
using Native.Service.DTOs.Request;
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

        [HttpPost("bylocation")]
        public async Task<IEnumerable<VenueDTO>> GetVenuesByLocation(AreaDTO area) =>
            await _venueService.GetVenuesByLocation(area);

        [HttpGet("{guid}")]
        public async Task<DetailedVenueDTO> GetVenue(Guid guid) =>
            await _venueService.GetDetailedVenue(guid);

        [HttpPost]
        public async Task<IActionResult> CreateVenue(CreateVenueRequest request)
        {
            var venue = _mapper.Map<Venue>(request);
            await _venueService.CreateNewVenue(venue, request.InterestGuids);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPost("{guid}/visit")]
        public async Task<IActionResult> AddProfileToVenueVistors(AddProfileToVenueRequest request)
        {
            await _venueService.AddProfileToVenueVisitors(
                request.VenueGuid, 
                request.HasProfileUpvoted, 
                request.HasProfileDownvoted);
            return StatusCode(StatusCodes.Status200OK);
        }
            
    }
}
