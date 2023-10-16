using Native.Domain.Models;
using Native.Domain.Models.Interfaces;
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
        Task AddInterestsToUser(IEnumerable<Guid> interestGuids, Profile profile);

        Task AddInterestsToInterestsPossesor(IEnumerable<Guid> interestGuids, IInterestPossessor interestPossesor);
    }
}
