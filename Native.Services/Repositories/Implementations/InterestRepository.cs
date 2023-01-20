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

namespace Native.Repositories.Repositories.Implementations
{
    internal class InterestRepository : Repository<Interest>, IInterestRepository
    {
        public InterestRepository(NativeContext nativeContext) : base(nativeContext) { }
            
        
    }
}
