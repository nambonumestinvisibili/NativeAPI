using Native.Domain.DataAccess;
using Native.Domain.Models;
using Native.Repositories.Repositories.Contracts;
using Native.Repositories.Repositories.Implementations;
using Native.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Repositories.Repositories
{
    internal class RepositoryManager : IRepositoryManager
    {
        private IVenueRepository? _venueRepository;
        private IInterestRepository? _interestRepository;
        private readonly NativeContext _nativeContext;

        public RepositoryManager(NativeContext nativeContext)
        {
            _nativeContext = nativeContext;
        }

        public IVenueRepository Venue => _venueRepository ??= new VenueRepository(_nativeContext);

        public IInterestRepository Interest => _interestRepository ??= new InterestRepository(_nativeContext);

        public async Task Save() => await _nativeContext.SaveChangesAsync();

        public IRepository<T> GetRepoByResourceType<T>() where T : Entity
        {
            return (typeof(T).Name switch
            {
                nameof(Venue) => (IRepository<T>) Venue,
                nameof(Interest) => (IRepository<T>) Interest,
                _ => throw new InvalidOperationException("There is no repository for this resource")
            });
        }
    }
}
