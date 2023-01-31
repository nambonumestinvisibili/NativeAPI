using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        public AuthenticationController(IMapper mapper, IUserService userService) 
            : base(mapper)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> RegisterWithApple(AppleCreateUserRequest request) =>
            Ok(await _userService.CreateOrLoginUser(_mapper.Map<ThirdParyTokenLoginOrCreateAccountDTO>(request)));
        
    }
}
