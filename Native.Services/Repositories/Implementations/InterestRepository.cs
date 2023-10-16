using Microsoft.EntityFrameworkCore;
using Native.Domain.Models;
using Native.Domain.DataAccess;
using Native.Repositories.Infrastructure.Exceptions;
using Native.Repositories.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using LanguageExt.TypeClasses;
using System.ComponentModel;
using Native.Domain.Models.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Native.Repositories.Repositories.Implementations
{
    internal class InterestRepository : Repository<Interest>, IInterestRepository
    {
        public InterestRepository(NativeContext nativeContext) : base(nativeContext) { }

        public async Task AddInterestsToInterestsPossesor(IEnumerable<Guid> interestGuids, IInterestPossessor interestPossesor)
        {
            var (_, chosenInterests) = await GetInterestsByGuids(interestGuids);
            chosenInterests.ToList().ForEach(interestPossesor.Interests.Add);
            await NativeContext.SaveChangesAsync();
        }

        public async Task AddInterestsToUser(IEnumerable<Guid> interestGuids, Profile profile)
        {
            var (_, chosenInterests) = await GetInterestsByGuids(interestGuids);
            chosenInterests.ToList().ForEach(profile.Interests.Add);
            await NativeContext.SaveChangesAsync();
        }

        public async Task<(bool doInterestExist, IEnumerable<Interest> interests)> GetInterestsByGuids(IEnumerable<Guid> interestGuids)
        {
            var chosenInterests = await NativeContext.Interests.Where(interest =>
                interestGuids.Contains(interest.Guid))
                .ToListAsync();

            if (chosenInterests.Count != interestGuids.Count())
            {
                var missingGuids = interestGuids.Except(
                    chosenInterests.Select(interest => interest.Guid));
                throw new NotFoundException(nameof(Interest), missingGuids);
            }

            return (true, chosenInterests);
        }
    }
}
