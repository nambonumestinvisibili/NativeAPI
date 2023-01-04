using Microsoft.EntityFrameworkCore;
using Native.Domain.Models;
using Native.Services.DataAccess;
using Native.Services.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Native.Services.Repositories.Implementations
{
    internal class VenueRepository : Repository<Venue>, IVenueRepository
    {
        public VenueRepository(NativeContext nativeContext) : base(nativeContext) { }

        public async Task<IEnumerable<Venue>> GetAll() => await base.FindAll().ToListAsync();

    }
}
