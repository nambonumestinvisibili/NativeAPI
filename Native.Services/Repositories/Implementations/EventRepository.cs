using Native.Domain.DataAccess;
using Native.Domain.Models;
using Native.Repositories.Repositories.Contracts;

namespace Native.Repositories.Repositories.Implementations
{
    internal class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(NativeContext context) : base(context)
        {
        }
    }
}