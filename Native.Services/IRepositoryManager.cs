using Native.Services.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Services
{
    public interface IRepositoryManager
    {
        IVenueRepository Venue { get; }
        IInterestRepository Interest { get; }
        Task Save();
    }
}
