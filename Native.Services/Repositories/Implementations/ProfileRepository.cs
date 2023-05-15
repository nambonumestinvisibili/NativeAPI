using Microsoft.EntityFrameworkCore;
using Native.Domain.DataAccess;
using Native.Domain.Models;
using Native.Repositories.Repositories.Contracts;

namespace Native.Repositories.Repositories.Implementations
{
    internal class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(NativeContext context) : base(context)
        {
        }

        public async Task<Profile> GetDetailedProfile(Guid profileGuid) => 
            await NativeContext.Profiles.Include(assoc => assoc.Interests)
            .FirstOrDefaultAsync(profile => profile.Guid == profileGuid);
        
    }
}