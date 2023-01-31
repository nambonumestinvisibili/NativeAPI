using LanguageExt;
using LanguageExt.SomeHelp;
using Microsoft.AspNetCore.Identity;
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
    //[AllowAnonymous]
    public class UserService : IUserService
    {
        private readonly string APPLE_JWKS_ENDPOINT = "https://appleid.apple.com/auth/keys";
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;

        public UserService(UserManager<User> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
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

        private async Task<string> LoginUser(string user, string identityToken) 
        {
            if (!ValidateRequestForLogin(user, identityToken))
            {
                throw new Exception("!!!");
            }
            if (!await ValidateAppleToken(identityToken, APPLE_JWKS_ENDPOINT))
            {
                throw new Exception("FUCK OFFF!!!!");
            }

            return GenerateToken(user);
        }

        private async Task<string> CreateUser(ThirdParyTokenLoginOrCreateAccountDTO request)
        {
            if (!ValidateRequestForCreate(request))
            {
                throw new Exception("!!!");
            }

            if (!await ValidateAppleToken(request.IdentityToken, APPLE_JWKS_ENDPOINT))
            {
                throw new Exception("FUCK OFFF!!!!");
            }

            Profile profile = new()
            {
                FirstName = request.GivenName!,
                SecondName = request.FamilyName!,
                Bio = "",
                Introduction = ""
            };
            
            User user = new()
            {
                Email = request.Email,
                UserName = request.User,
                Profile = profile,
            };

            var result = await _userManager.CreateAsync(user);
            
            if (result.Succeeded)
            {
                return GenerateToken(request.User);
            }
            throw new Exception("Error");
        }

        private string GenerateToken(string user)
        {
            var issuer = _configuration["Jwt:Issuer"];
            var audience = _configuration["Jwt:Audience"];
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]!);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[] //explain
                {
                    new Claim("Id", Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Sub, user),
                    new Claim(JwtRegisteredClaimNames.Email, user),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(int.Parse(_configuration["Jwt:ExpirationTimeInMinutes"]!)),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }

        private static async Task<bool> ValidateAppleToken(string identityToken, string endpoint)
        {
            JwtSecurityToken securityToken = new(identityToken);

            string kid;
            try
            {
                kid = securityToken.Header["kid"].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("");
            }

            HttpClient client = new();
            HttpResponseMessage response;
            try
            {
                response = await client.GetAsync(endpoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                response = null;
            }
            var responseString = await response.Content.ReadAsStringAsync();
            var jwks = new JsonWebKeySet(responseString);
            var signingKeys = jwks.GetSigningKeys();

            var validationParameters = new TokenValidationParameters
            {
                IssuerSigningKeys = signingKeys,
                ValidateAudience = false, // Your API Audience, can be disabled via ValidateAudience = false
                ValidateIssuer = false  // Your token issuer, can be disabled via ValidateIssuer = false
            };

            return ValidateToken(identityToken, validationParameters);
        }

        private static bool ValidateToken(string token, TokenValidationParameters validationParameters)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                tokenHandler.ValidateToken(token, validationParameters, out var validatedToken);
                return validatedToken != null;
            }
            catch (Exception)
            {
                return false;
            }
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
