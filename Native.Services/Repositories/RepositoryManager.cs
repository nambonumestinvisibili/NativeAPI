using Native.Services.DataAccess;
using Native.Services.Repositories.Contracts;
using Native.Services.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Services.Repositories
{
    internal class RepositoryManager : IRepositoryManager
    {
        private IVenueRepository _venueRepository;
        private IInterestRepository _interestRepository;
        private NativeContext _nativeContext;

        public RepositoryManager(NativeContext nativeContext)
        {
            _nativeContext = nativeContext;
        }

        public IVenueRepository Venue => _venueRepository ??= new VenueRepository(_nativeContext);

        public IInterestRepository Interest => _interestRepository ??= new InterestRepository(_nativeContext);

        public async Task Save() => await _nativeContext.SaveChangesAsync();
    }
}
