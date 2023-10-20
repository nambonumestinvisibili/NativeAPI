using AutoMapper;
using Native.Domain.Models;
using Native.Repositories;

namespace Native.Service.Services.Cities
{
    internal class CityService : ResourceService<City>, ICityService
    {
        public CityService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
        {
        }
    }
}
