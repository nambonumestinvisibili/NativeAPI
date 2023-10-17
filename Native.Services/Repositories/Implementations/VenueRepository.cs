using Microsoft.EntityFrameworkCore;
using Native.Domain.Models;
using Native.Domain.DataAccess;
using Native.Repositories.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Native.Repositories.Repositories.Implementations
{
    internal class VenueRepository : Repository<Venue>, IVenueRepository
    {
        public VenueRepository(NativeContext nativeContext) : base(nativeContext) { }

        public async Task<Venue> GetDetailedVenue(Guid guid)
        {
            return await NativeContext.Venues
                .Include(ve => ve.Interests)
                .Include(ve => ve.ProfilesThatVisitedVenue)
                    .ThenInclude(pr => pr.Profile)
                        .ThenInclude(prof => prof.CitiesThatTheProfileVisited)
                .GetByGuidAsync(guid);
        }

    }
}
