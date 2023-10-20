using Native.Domain.Models;
using Native.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Repositories.Repositories.Contracts
{
    public interface IVenueRepository : IRepository<Venue>
    {
        Task<IEnumerable<Venue>> GetByLocation(double longitudeLeft, double longitudeRight, double latitudeTop, double latitudeDown);
        Task<Venue> GetDetailedVenue(Guid guid);
    }
}
