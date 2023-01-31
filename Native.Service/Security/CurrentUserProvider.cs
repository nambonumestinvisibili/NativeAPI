using Microsoft.AspNetCore.Http;
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

        public CurrentUserProvider(IHttpContextAccessor context)
        {
            _context = context;
        }

        public string GetUserName()
        {
            return _context.HttpContext.User.Claims.First(claims => claims.Type == ClaimTypes.Name).Value;
        }
    }
}
