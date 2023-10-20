using Native.Domain.Models;
using Native.Service.Repositories;

namespace Native.Repositories.Repositories.Contracts
{
    public interface ILocationRepository : IRepository<Location>
    {
        Task<Location> GetIfExistsOrAdd(double longitude, double latitude);
    }
}