using Microsoft.EntityFrameworkCore;
using Native.Domain.Models;
using Native.Service.Services.Interfaces;
using Native.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services
{
    internal class ResourceService<T> : IResourceService<T> where T : Entity
    {
        protected readonly IRepositoryManager _repositoryManager;

        public ResourceService(IRepositoryManager repositoryManager) 
        {
            _repositoryManager = repositoryManager;
        }

        public Task Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => 
            await _repositoryManager.GetRepoByResourceType<T>()
                .FindAll(trackChanges: false)
                .ToListAsync();

        public async Task<T> GetByGuid(Guid guid) => await _repositoryManager.GetRepoByResourceType<T>()
            .GetByGuid(guid);

        public async Task<T> GetById(int id) => 
            await _repositoryManager.GetRepoByResourceType<T>()
            .GetById(id);
    }
}
