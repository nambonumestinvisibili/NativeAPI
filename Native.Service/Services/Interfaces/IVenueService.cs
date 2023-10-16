using Native.Domain.Models;
using Native.Service.DTOs;
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

        Task<VenueDTO> GetDetailedVenue(Guid guid);
    }
}
