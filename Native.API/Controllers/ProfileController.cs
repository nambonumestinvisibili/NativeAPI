using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Native.API.Requests;
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

        //get my own profile - we need a check!
        [HttpGet("{guid}")]
        public async Task<IActionResult> GetOtherUserProfile(Guid guid) =>
            Ok(await _profileService.GetByGuid<ProfileDTO>(guid));

        [HttpGet]
        public async Task<IActionResult> GetCurrentUserProfile() =>
            Ok(await _profileService.GetCurrentUserProfile());

        //[HttpPost]
        //public async Task<IActionResult> CreateProfile(CreateProfileRequest request)
        //{
        //    var profileDTO = _mapper.Map<ProfileDTO>(request);
        //    await _profileService.CreateNewProfile(profileDTO);
        //    return StatusCode(StatusCodes.Status201Created);
        //}
    }
}
