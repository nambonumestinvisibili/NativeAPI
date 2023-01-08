using Native.Domain.Models;
using Native.Repositories.Repositories;
using Native.Repositories.Repositories.Contracts;
using Native.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Repositories
{
    public interface IRepositoryManager
    {
        IRepository<T> GetRepoByResourceType<T>() where T : Entity;
        IVenueRepository Venue { get; }
        IInterestRepository Interest { get; }
        Task Save();
    }
}
