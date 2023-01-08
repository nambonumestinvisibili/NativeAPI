using Native.Domain.Models;
using Native.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Repositories.Repositories.Contracts
{
    public interface IInterestRepository : IRepository<Interest>
    {
        Task<IEnumerable<Interest>> FindAllOfGuids(IEnumerable<Guid> guids);
    }
}
