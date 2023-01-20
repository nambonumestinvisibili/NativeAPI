using AutoMapper;
using Native.Domain.Models;
using Native.Repositories;
using Native.Service.DTOs;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services
{
    internal class EventService : ResourceService<Event>, IEventService
    {
        public EventService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
        {
        }

        public async Task CreateEvent(EventDTO nativeEvent, Guid locationGuid, ICollection<Guid> interestGuids, ICollection<Guid> invitedProfilesGuids)
        {
            var location = await _repositoryManager.Location.GetByGuidAsync(locationGuid);
            var interests = (await _repositoryManager.Interest.GetAllOfGuids(interestGuids)).ToList();
            var invitedProfiles = (await _repositoryManager.Profile.GetAllOfGuids(invitedProfilesGuids)).ToList();
            var eventEntity = _mapper.Map<Event>(nativeEvent);
            eventEntity.Residence = location;
            eventEntity.Interests = interests;
            eventEntity.InvitedGuests = (ICollection<ProfileEvent>) invitedProfiles.Select(invitedProfile => new ProfileEvent()
            {

            });
            _repositoryManager.Event.Create(eventEntity);
            await _repositoryManager.Save();
        }
    }
}
