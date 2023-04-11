using LanguageExt;
using LanguageExt.SomeHelp;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Native.Domain.Models;
using Native.Repositories.Infrastructure.Exceptions;
using Native.Service.DTOs;
using Native.Service.DTOs.Request;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly TokenService _tokenService;

        public UserService(UserManager<User> userManager, 
            IConfiguration configuration,
            TokenService tokenService, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _tokenService = tokenService;
        }

        public async Task<string?> Login(LoginRequest loginRequest)
        {
            if (!ValidateRequestForLogin(loginRequest))
            {
                throw new Exception("Missing request parameters");
            }

            User user = await _userManager.Users
                .Include(user => user.Profile)
                .FirstOrDefaultAsync(dbUser => dbUser.Email == loginRequest.Email)
                ?? throw new UserNotFoundException();
            
            var result = await _signInManager.CheckPasswordSignInAsync(
                user,
                loginRequest.Password,
                lockoutOnFailure: false);
            
            if (result.Succeeded)
            {
                return _tokenService.GenerateToken(user);
            }
            return null;
        }

        public async Task<string?> SignUp(SignUpRequest request)
        {
            if (!ValidateRequestForCreate(request))
            {
                throw new Exception("Missing request parameters");
            }

            Profile profile = new()
            {
                Guid = Guid.NewGuid(),
                FirstName = request.GivenName!,
                SecondName = request.FamilyName!,
                Bio = "",
                Introduction = ""
            };

            User user = new()
            {
                Email = request.Email,
                UserName = request.UserName,
                Profile = profile,
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (result.Succeeded)
            {
                return _tokenService.GenerateToken(user);
            }

            throw new Exception("Couldnt create user");
        }

        private static bool ValidateRequestForCreate(SignUpRequest request) => new[]
        {
            request.UserName,
            request.Email,
            request.FamilyName,
            request.GivenName,
        }.All(data => !data.IsNullOrEmpty());

        private static bool ValidateRequestForLogin(LoginRequest request) => new[]
        {
            request.Email,
            request.Password
        }.All(data => !data.IsNullOrEmpty());

    }
}
