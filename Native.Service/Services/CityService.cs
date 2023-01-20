using AutoMapper;
using Native.Domain.Models;
using Native.Repositories;
using Native.Service.Services.Interfaces;

namespace Native.Service.Services
{
    internal class CityService : ResourceService<City>, ICityService
    {
        public CityService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
        {
        }
    }
}
