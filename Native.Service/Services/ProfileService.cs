using Native.Domain.Models;
using Native.Repositories;
using Native.Service.DTOs;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services
{
    internal class ProfileService : ResourceService<Profile>, IProfileService
    {
        public ProfileService(IRepositoryManager repositoryManager, AutoMapper.IMapper mapper) : base(repositoryManager, mapper)
        {
        }

        public Task CreateNewProfile(ProfileDTO profileDTO)
        {
            
        }
    }
}
