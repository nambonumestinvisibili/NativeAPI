using Native.Domain.Models;
using Native.Service.Services.Interfaces;
using Native.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Native.Repositories;
using AutoMapper;

namespace Native.Service.Services
{
    internal class VenueService : ResourceService<Venue>, IVenueService
    {
        public VenueService(
            IMapper mapper, 
            IRepositoryManager repositoryManager
            ) : base(repositoryManager, mapper)
        {
        }

        public async Task CreateNewVenue(Venue venue, IEnumerable<Guid> interestGuids)
        {
            var interests = await _repositoryManager.Interest.GetAllOfGuids(interestGuids.ToList());
            venue.Interests = interests.ToList();
            _repositoryManager.Venue.Create(venue);
            await _repositoryManager.Save();
        }
    }
}
