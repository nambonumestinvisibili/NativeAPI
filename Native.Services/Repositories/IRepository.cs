using Native.Domain.Models;
using Native.Domain.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Native.Service.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> GetByGuidAsync(Guid guid);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllOfGuids(ICollection<Guid> guids);
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
