using Native.Domain.Models;
using Native.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services.Interfaces
{
    public interface IResourceService<T> where T : Entity 
    {
        Task<IEnumerable<U>> GetAllAsync<U>() where U : IDTOConvertible<T>;
        Task<U> GetByGuid<U>(Guid guid) where U : IDTOConvertible<T>;
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Delete(T entity);
        Task Update(T entity);

    }
}
