using Microsoft.AspNetCore.Identity;
using Native.Domain.Models;
using Native.Repositories.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Security
{
    public interface ICurrentUserProvider
    {
        string GetUserGuid();
        Task<User> GetUser();
    }
}
