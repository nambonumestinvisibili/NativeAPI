using AutoMapper;
using Native.Domain.Models;
using Native.Repositories;
using Native.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services
{
    internal class ResidenceService : ResourceService<Location>, IResidenceService
    {
        public ResidenceService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
        {
        }
    }
}
