using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Native.API.Requests;
using Native.Service.DTOs;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Controllers
{
    public class EventController : NativeApiController
    {
        private readonly IEventService _eventService;
        public EventController(IMapper mapper, IEventService eventService) : base(mapper)
        {
            _eventService = eventService;
        }

        [HttpGet("{guid}")]
        public async Task<IActionResult> GetEvent(Guid guid) =>
            Ok(await _eventService.GetByGuid<EventDTO>(guid));

        [HttpPost]
        public async Task<IActionResult> CreateEvent(CreateEventRequest request)
        {
            var nativeEvent = _mapper.Map<EventDTO>(request);
            await _eventService.CreateEvent(
                nativeEvent, 
                request.LocationGuid, 
                request.InterestGuids,
                request.InvitedProfilesGuids
                );
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
