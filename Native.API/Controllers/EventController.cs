using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Native.Service.DTOs;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
