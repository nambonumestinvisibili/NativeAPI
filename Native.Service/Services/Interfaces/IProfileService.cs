using Native.Domain.Models;
using Native.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services.Interfaces
{
    public interface IProfileService : IResourceService<Profile>
    {
        Task<DetailedProfileDTO> GetCurrentUserProfile();
    }
}
