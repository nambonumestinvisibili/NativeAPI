using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services
{
    public class TokenService
    {
        private readonly IConfiguration _configuration;
        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(User user)
        {
            var issuer = _configuration["Jwt:Issuer"];
            var audience = _configuration["Jwt:Audience"];
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]!);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[] //explain
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Profile.Guid.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                }),
                Expires = DateTime.UtcNow.AddMinutes(int.Parse(_configuration["Jwt:ExpirationTimeInMinutes"]!)),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), 
                    SecurityAlgorithms.HmacSha512Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }

        #region [Unused - Apple validation]
        public static async Task<bool> ValidateAppleToken(string identityToken, string endpoint)
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
        #endregion

    }
}
