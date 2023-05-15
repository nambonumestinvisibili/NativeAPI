using Native.Domain.Models;
using Native.Service.Repositories;

namespace Native.Repositories.Repositories.Contracts
{
    public interface IProfileRepository : IRepository<Profile>
    {
        Task<Profile> GetDetailedProfile(Guid profileGuid);
    }
}