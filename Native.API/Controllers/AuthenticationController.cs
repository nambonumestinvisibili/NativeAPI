using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Native.API.Requests;
using Native.Domain.Models;
using Native.Service.DTOs;
using Native.Service.DTOs.Request;
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
        private readonly ILogger _logger;

        public AuthenticationController(
            IMapper mapper,
            IUserService userService,
            IFakeUserService fakeUserService,
            IWebHostEnvironment webHostEnvironment,
            ILogger<AuthenticationController> logger)
            : base(mapper)
        {
            _logger = logger;
            _userService = userService;
            _fakeUserService = fakeUserService;
            _environment = webHostEnvironment;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            string? token = await _userService.Login(loginRequest);
            return token == null ? Unauthorized() : Ok(token);
        }

        [AllowAnonymous]
        [HttpPost("signUp")]
        public async Task<IActionResult> SignUp(SignUpRequest signUpRequest)
        {
            string? token = await _userService.SignUp(signUpRequest);
            return token == null ? Unauthorized() : Ok(token);
        }

        [HttpPost("register/basics")]
        public async Task<IActionResult> RegisterName(BasicInfoRegistrationRequest request)
        {
            await _userService.RegisterBasicInfo(request);
            return Ok();
        }

        [HttpPost("register/description")]
        public async Task<IActionResult> RegisterBioAndIntro(DescriptionRegistrationRequest request)
        {
            await _userService.RegisterBioAndIntro(request);
            return Ok();
        }

        [HttpPost("register/interests")]
        public async Task<IActionResult> RegisterInterests(List<Guid> interestGuids)
        {
            await _userService.RegisterInterests(interestGuids);
            return Ok();
        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await _userService.Logout();
            return Ok();
        }
    }
}
