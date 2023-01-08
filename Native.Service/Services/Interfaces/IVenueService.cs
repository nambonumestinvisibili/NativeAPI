using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services.Interfaces
{
    public interface IVenueService : IResourceService<Venue>
    {
        Task CreateNewVenue(Venue venue, IEnumerable<Guid> interestGuids);
    }
}
