using LanguageExt;
using LanguageExt.SomeHelp;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Native.Domain.Models;
using Native.Service.DTOs;
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
        private readonly string APPLE_JWKS_ENDPOINT;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly TokenService _tokenService;

        public UserService(UserManager<User> userManager, 
            IConfiguration configuration,
            TokenService tokenService)
        {
            _userManager = userManager;
            _configuration = configuration;
            _tokenService = tokenService;
            APPLE_JWKS_ENDPOINT = configuration["Jwt:AppleTokenValidationUrl"]!;
        }

        public async Task<string> CreateOrLoginUser(ThirdParyTokenLoginOrCreateAccountDTO request)
        {
            if (request.Email == null)
            {
                return await LoginUser(request.User, request.IdentityToken);
            }   
            else
            {
                return await CreateUser(request);
            }
        }

        private async Task<string> LoginUser(string userId, string identityToken) 
        {
            if (!ValidateRequestForLogin(userId, identityToken))
            {
                throw new Exception("Login object not proper");
            }
            if (!await TokenService.ValidateAppleToken(identityToken, APPLE_JWKS_ENDPOINT))
            {
                throw new Exception("Not an Apple token.");
            }

            User? user = await _userManager.Users
                .FirstOrDefaultAsync(dbUser => dbUser.AppleUserId == userId);

            if (user == null)
            {
                throw new Exception("User doesn't exist");
            }
            return _tokenService.GenerateToken(user);
        }

        private async Task<string> CreateUser(ThirdParyTokenLoginOrCreateAccountDTO request)
        {
            if (!ValidateRequestForCreate(request))
            {
                throw new Exception("!!!");
            }

            if (!await TokenService.ValidateAppleToken(request.IdentityToken, APPLE_JWKS_ENDPOINT))
            {
                throw new Exception("FUCK OFFF!!!!");
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
                AppleUserId = request.User,
                Email = request.Email,
                UserName = request.User,
                Profile = profile,
            };

            var result = await _userManager.CreateAsync(user);
            
            if (result.Succeeded)
            {
                return _tokenService.GenerateToken(user);
            }
            throw new Exception("Error");
        }

        private static bool ValidateRequestForCreate(ThirdParyTokenLoginOrCreateAccountDTO request) => new[]
        {
            request.Email,
            request.User,
            request.FamilyName,
            request.GivenName,
            request.IdentityToken
        }.All(data => !data.IsNullOrEmpty());

        private static bool ValidateRequestForLogin(string user, string identityToken) => new[]
        {
            user,
            identityToken
        }.All(data => !data.IsNullOrEmpty());

    }
}
