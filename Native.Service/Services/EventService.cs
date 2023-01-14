using AutoMapper;
using Native.Domain.Models;
using Native.Repositories;
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
    }
}
