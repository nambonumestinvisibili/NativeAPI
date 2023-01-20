using Native.Domain.DataAccess;
using Native.Domain.Models;
using Native.Repositories.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Repositories.Repositories.Implementations
{
    internal class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(NativeContext context) : base(context)
        {
        }
    }
}
