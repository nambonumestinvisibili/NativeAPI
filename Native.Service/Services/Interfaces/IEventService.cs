using Native.Domain.Models;
using Native.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services.Interfaces
{
    public interface IEventService : IResourceService<Event>
    {
        Task CreateEvent(
            EventDTO nativeEvent, 
            Guid locationGuid, 
            ICollection<Guid> interestGuids,
            ICollection<Guid> invitedProfilesGuids
            );
    }
}
