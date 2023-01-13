using Native.Domain.Models;
using Native.Service.Services.Interfaces;
using Native.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Native.Repositories;

namespace Native.Service.Services
{
    internal class VenueService : ResourceService<Venue>, IVenueService
    {
        public VenueService(IRepositoryManager repositoryManager) : base(repositoryManager)
        {
        }

        public async Task CreateNewVenue(Venue venue, IEnumerable<Guid> interestGuids)
        {
            var interests = await _repositoryManager.Interest.FindAllOfGuids(interestGuids);
            venue.Interests = interests.ToList();
            _repositoryManager.Venue.Create(venue);
            await _repositoryManager.Save();
        }
    }
}
