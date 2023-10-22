using Microsoft.EntityFrameworkCore;
using Native.Domain.DataAccess;
using Native.Domain.Models;
using Native.Repositories.Infrastructure.Exceptions;
using Native.Repositories.Repositories.Contracts;

namespace Native.Repositories.Repositories.Implementations
{
    internal class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(NativeContext context) : base(context)
        {
        }

        public async Task AddCityToProfile(Profile profile, City city, bool isProfileNativeToTheCity)
        {
            var profileAlreadyHasNativeCity = (await GetByGuidWithIncludesAsync(profile.Guid, x => x.CitiesThatTheProfileVisited))
                .CitiesThatTheProfileVisited
                .Any(city => city.IsProfileNativeToTheCity);

            if (isProfileNativeToTheCity && profileAlreadyHasNativeCity)
            {
                throw new ConflictException($"Profile of guid {profile.Guid} already has native city");
            }

            ProfileCity profileCity = new()
            {
                City = city,
                Profile = profile,
                IsProfileNativeToTheCity = isProfileNativeToTheCity
            };

            NativeContext.ProfileCity.Add(profileCity);
            await NativeContext.SaveChangesAsync();
        }

        public async Task<Profile> GetDetailedProfile(Guid profileGuid) => 
            await NativeContext.Profiles
                .Include(assoc => assoc.Interests)
                .Include(profile => profile.CitiesThatTheProfileVisited)
            .GetByGuidAsync(profileGuid);

        public async Task<Votes> GetVotes(Venue venue)
        {
            var profileVenueTableWithSpecificVenueQuery = NativeContext.ProfileVenues
                .Include(pv => pv.Profile)
                    .ThenInclude(pr => pr.CitiesThatTheProfileVisited)
                .Where(profileVenue => profileVenue.VenueId == venue.Id);

            // PROFILE needs to have NATIVE cities ASSIGNED... if city == null 

            var calculation = await profileVenueTableWithSpecificVenueQuery
                .GroupBy(
                    profileVenue => 
                        profileVenue.Profile.CitiesThatTheProfileVisited
                            .Any(profileCity => profileCity.CityId == venue.Location.City.Id
                                && profileCity.IsProfileNativeToTheCity),
                    (isNative, profileVenues) => new
                    {
                        IsNative = isNative,
                        ProfileUpvotesCount = profileVenues.Sum(pv => pv.ProfileUpvoted ? 1 : 0),
                        ProfileDownVotesCount = profileVenues.Sum(pv => pv.ProfileDownvoted ? 1 : 0)
                    }
                ).ToDictionaryAsync(x => x.IsNative);

            var nativeVotes = calculation.FirstOrDefault(x => x.Key == true).Value;
            var touristVotes = calculation.FirstOrDefault(x => x.Key == false).Value;

            return new Votes(
                new VotesBreakdown(nativeVotes?.ProfileUpvotesCount ?? 0, touristVotes?.ProfileUpvotesCount ?? 0), 
                new VotesBreakdown(nativeVotes?.ProfileDownVotesCount ?? 0, touristVotes?.ProfileDownVotesCount ?? 0));
        }
    }
}