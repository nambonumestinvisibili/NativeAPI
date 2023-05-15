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

namespace Native.Repositories.Repositories.Implementations
{
    internal class InterestRepository : Repository<Interest>, IInterestRepository
    {
        public InterestRepository(NativeContext nativeContext) : base(nativeContext) { }

        public async Task AddInterestsToUser(IEnumerable<Guid> interestGuids, Profile profile)
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

            chosenInterests.ForEach(profile.Interests.Add);

            await NativeContext.SaveChangesAsync();
        }
    }
}
