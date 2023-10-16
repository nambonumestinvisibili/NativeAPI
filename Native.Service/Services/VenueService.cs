using Native.Domain.Models;
using Native.Service.Services.Interfaces;
using Native.Repositories;
using AutoMapper;
using Native.Service.DTOs;

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
            _repositoryManager.Venue.Create(venue);
            await _repositoryManager.Save();

            await _repositoryManager.Interest.AddInterestsToInterestsPossesor(interestGuids, venue);
            await _repositoryManager.Save();
        }

        public async Task<VenueDTO> GetDetailedVenue(Guid guid)
        {
            var venue = await _repositoryManager.Venue.GetByGuidWithIncludesAsync(guid, x => x.Interests);
            return _mapper.Map<VenueDTO>(venue);
        }
    }
}
