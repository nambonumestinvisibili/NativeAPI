using Native.Domain.Models;
using Native.Service.Services.Interfaces;
using Native.Repositories;
using AutoMapper;
using Native.Service.DTOs;
using Native.Service.Security;
using Native.Service.Exceptions;
using Native.Service.DTOs.Request;
using LanguageExt;

namespace Native.Service.Services
{
    internal class VenueService : ResourceService<Venue>, IVenueService
    {
        private readonly ICurrentUserProvider _currentUserProvider;

        public VenueService(
            IMapper mapper, 
            IRepositoryManager repositoryManager,
            ICurrentUserProvider currentUserProvider
            ) : base(repositoryManager, mapper)
        {
            _currentUserProvider = currentUserProvider;
        }

        public async Task CreateNewVenue(Venue venue, IEnumerable<Guid> interestGuids)
        {
            _repositoryManager.Venue.Create(venue);
            await _repositoryManager.Save();

            await _repositoryManager.Interest.AddInterestsToInterestsPossesor(interestGuids, venue);
            await _repositoryManager.Save();
        }

        public async Task<DetailedVenueDTO> GetDetailedVenue(Guid guid)
        {
            var venue = await _repositoryManager.Venue.GetDetailedVenue(guid);
            var venueDTO = _mapper.Map<VenueDTO>(venue);

            var votes = await _repositoryManager.Profile.GetVotes(venue);

            return new DetailedVenueDTO(venueDTO, votes);
        }

        public async Task AddProfileToVenueVisitors(Guid venueGuid, bool hasProfileUpvotes, bool hasProfileDownVoted)
        {
            if (HasProfileBothUpAndDownVoted(hasProfileUpvotes, hasProfileDownVoted))
            {
                throw new ValidationException("Profile cannot both up and down vote");
            }

            var profileGuid = await _currentUserProvider.GetUserProfileGuid();
            var profile = await _repositoryManager.Profile.GetByGuidWithIncludesAsync(profileGuid, x => x.CitiesThatTheProfileVisited);
            var venue = await _repositoryManager.Venue.GetDetailedVenue(venueGuid);
            var cityVenueIsIn = venue.Location.City;

            await _repositoryManager.City.VisitCityByProfileIfNotVisitedBefore(profile, cityVenueIsIn);

            var pv = new ProfileVenue()
            {
                Profile = profile,
                Venue = venue,
                ProfileUpvoted = hasProfileUpvotes,
                ProfileDownvoted = hasProfileDownVoted
            };
            venue.ProfilesThatVisitedVenue.Add(pv);
            await _repositoryManager.Save();
        }

        private bool HasProfileBothUpAndDownVoted(bool upvoted, bool downvoted) => upvoted && downvoted;

        public async Task<IEnumerable<VenueDTO>> GetVenuesByLocation(AreaDTO req)
        {
            double latitudeLeft = req.Latitude - req.DeltaLatitude;
            double latitudeRight = req.Latitude + req.DeltaLatitude;
            double longitudeLeft = req.Longitude - req.DeltaLongitude;
            double longitudeRight = req.Longitude + req.DeltaLongitude;

            return (await _repositoryManager.Venue
                .GetByLocation(longitudeLeft, longitudeRight, latitudeLeft, latitudeRight))
                .Select(_mapper.Map<VenueDTO>);
        }
    }
}
