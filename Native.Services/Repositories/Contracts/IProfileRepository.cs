﻿using Native.Domain.Models;
using Native.Service.Repositories;

namespace Native.Repositories.Repositories.Contracts
{
    public interface IProfileRepository : IRepository<Profile>
    {
        Task AddCityToProfile(Profile profileGuid, City city, bool isProfileNativeToTheCity);
        Task<bool> CheckIfProfileVisitedVenue(Guid task, Guid guid);
        Task<Profile> GetDetailedProfile(Guid profileGuid);
        Task<Votes> GetVotes(Venue venue);
    }
}