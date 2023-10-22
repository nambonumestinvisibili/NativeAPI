using Native.Domain.DataAccess;
using Native.Domain.Models;
using Native.Repositories;
using Native.Service.DTOs;
using Native.Service.Security;
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
        private readonly ICurrentUserProvider _currentUserProvider;

        public ProfileService(
            IRepositoryManager repositoryManager, 
            AutoMapper.IMapper mapper,
            ICurrentUserProvider currentUserProvider) : base(repositoryManager, mapper)
        {
            _currentUserProvider = currentUserProvider;
        }

        public async Task<DetailedProfileDTO> GetCurrentUserProfile()
        {
            var profileGuid = await _currentUserProvider.GetUserProfileGuid();
            var profile = await _repositoryManager.Profile.GetDetailedProfile(profileGuid);
            return _mapper.Map<DetailedProfileDTO>(profile);
        }

        public async Task<DetailedProfileDTO> GetOtherUserProfile(Guid profileGuid)
        {
            var profile = await _repositoryManager.Profile.GetDetailedProfile(profileGuid);
            return _mapper.Map<DetailedProfileDTO>(profile);
        }
    }
}
