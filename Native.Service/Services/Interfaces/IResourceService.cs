using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Services.Interfaces
{
    public interface IResourceService<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByGuid(Guid guid);
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Delete(T entity);
        Task Update(T entity);

    }
}
