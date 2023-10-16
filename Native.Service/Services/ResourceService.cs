using Microsoft.EntityFrameworkCore;
using Native.Domain.Models;
using Native.Service.Services.Interfaces;
using Native.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Native.Service.DTOs;
using AutoMapper;

namespace Native.Service.Services
{
    internal class ResourceService<T> : IResourceService<T> where T : Entity
    {
        protected readonly IRepositoryManager _repositoryManager;
        protected readonly IMapper _mapper;

        public ResourceService(IRepositoryManager repositoryManager, IMapper mapper) 
        {
            _mapper = mapper;
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

        public async Task<U> GetByGuid<U>(Guid guid) where U : IDTOConvertible<T> =>
            _mapper.Map<U>(await _repositoryManager.GetRepoByResourceType<T>()
            .GetByGuidAsync(guid));

        public async Task<T> GetById(int id) => 
            await _repositoryManager.GetRepoByResourceType<T>()
            .GetByIdAsync(id);

        public async Task<IEnumerable<U>> GetAllAsync<U>() where U : IDTOConvertible<T> =>
            _mapper.Map<IEnumerable<U>>(await GetAllRawAsync());
        
        private async Task<IEnumerable<T>> GetAllRawAsync() =>
            await _repositoryManager.GetRepoByResourceType<T>()
                .FindAll(trackChanges: false)
            .ToListAsync();
    }
}
