using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Native.Domain.Models;
using Native.Repositories.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Security
{
    internal class CurrentUserProvider : ICurrentUserProvider
    {
        private readonly IHttpContextAccessor _context;
        private readonly UserManager<User> _userManager;
        public CurrentUserProvider(IHttpContextAccessor context, UserManager<User> userManager)
        {
            _userManager = userManager; 
            _context = context;
        }

        public string GetUserGuid()
        {
            return _context.HttpContext.User.Claims
                .First(claims => claims.Type == ClaimTypes.NameIdentifier).Value;
        }

        public async Task<User> GetUser()
        {
            var claims = _context.HttpContext.User.Claims.ToList();  
            var userGuidFromClaim = claims.First(claims => claims.Type == ClaimTypes.NameIdentifier).Value;
            return await _userManager.Users.Include(user => user.Profile)
                .FirstOrDefaultAsync(dbUser => dbUser.Profile.Guid.ToString() 
                    == userGuidFromClaim) 
                ?? throw new UserNotFoundException();
        }
    }
}
