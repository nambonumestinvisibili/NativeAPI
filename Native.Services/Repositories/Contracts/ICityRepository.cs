using Native.Domain.DataAccess;
using Native.Domain.Models;
using Native.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Repositories.Repositories.Contracts
{
    public interface ICityRepository : IRepository<City>
    {
        Task<City> CreateCityIfDoesntExist(City city);
        Task VisitCityByProfileIfNotVisitedBefore(Profile profile, City city);
    }
}
