using Native.Domain.DataAccess;
using Native.Domain.Models;
using Native.Repositories.Repositories.Contracts;

namespace Native.Repositories.Repositories.Implementations
{
    internal class LocationRepository : Repository<Location>, ILocationRepository
    {
        public LocationRepository(NativeContext context) : base(context)
        {
        }
    }
}