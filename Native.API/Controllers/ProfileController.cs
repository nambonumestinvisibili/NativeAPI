using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Native.Service.DTOs;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Controllers
{
    public class ProfileController : NativeApiController
    {
        private readonly IProfileService _profileService;
        public ProfileController(IMapper mapper, IProfileService profileService) : base(mapper)
        {
            _profileService = profileService;
        }

        [HttpGet("{guid}")]
        public async Task<IActionResult> GetProfile(Guid guid) =>
            Ok(await _profileService.GetByGuid<ProfileDTO>(guid));
    }
}
