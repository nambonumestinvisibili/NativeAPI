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

        public async Task<Location> GetIfExistsOrAdd(double longitude, double latitude)
        {
            Location? location = NativeContext.Locations.SingleOrDefault(x => x.Longitude == longitude && x.Latitude == latitude);

            if (location == null)
            {
                Location newLocation = new()
                {
                    Longitude = longitude,
                    Latitude = latitude,
                };

                NativeContext.Locations.Add(newLocation);
                await NativeContext.SaveChangesAsync();
                return newLocation;
            }
            return location;
        }
    }
}