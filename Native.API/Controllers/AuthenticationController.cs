using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Native.API.Requests;
using Native.Domain.Models;
using Native.Service.DTOs;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Controllers
{
    public class AuthenticationController : NativeApiController
    {
        private readonly IUserService _userService;
        private readonly IFakeUserService _fakeUserService;
        private readonly IWebHostEnvironment _environment;
        public AuthenticationController(
            IMapper mapper,
            IUserService userService,
            IFakeUserService fakeUserService,
            IWebHostEnvironment webHostEnvironment)
            : base(mapper)
        {
            _userService = userService;
            _fakeUserService = fakeUserService;
            _environment = webHostEnvironment;
        }

#if DEBUG
        [AllowAnonymous]
        [HttpGet("fakeLogin")]
        public async Task<IActionResult> LoginAsFakeUser(string fakeAppleUserId) =>
            _environment.IsDevelopment()
                ? Ok(await _fakeUserService.LoginAsFakeUser(fakeAppleUserId))
                : Unauthorized();
#endif

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> RegisterWithApple(AppleCreateUserRequest request) =>
            Ok(await _userService.CreateOrLoginUser(_mapper.Map<ThirdParyTokenLoginOrCreateAccountDTO>(request)));
        
    }
}
