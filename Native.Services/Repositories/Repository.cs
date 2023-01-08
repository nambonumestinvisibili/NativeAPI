using Microsoft.EntityFrameworkCore;
using Native.Domain.Models;
using Native.Domain.DataAccess;
using Native.Repositories.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Native.Repositories.Repositories
{
    internal class Repository<T> where T : Entity
    {
        protected NativeContext NativeContext;

        public Repository(NativeContext context)
        {
            NativeContext = context;
        }

        public IQueryable<T> FindAll(bool trackChanges = true) => 
            !trackChanges ? 
                NativeContext.Set<T>()
                .AsNoTracking() :
            NativeContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ? 
                NativeContext.Set<T>()
                    .Where(expression)
                    .AsNoTracking() :
                NativeContext.Set<T>()
                    .Where(expression);

        public async Task<T> GetByGuid(Guid guid)
        {
            T? result = await NativeContext.Set<T>().SingleOrDefaultAsync(item => item.Guid == guid);
            ExceptionExtensions.ThrowNotFoundIfNull<T>(result, guid);
            return result!;
        }

        public async Task<T> GetById(int id)
        {
            T? result = await NativeContext.Set<T>().SingleOrDefaultAsync(item => item.Id == id);
            ExceptionExtensions.ThrowNotFoundIfNull<T>(result, id);
            return result!;
        }

        public void Create(T entity) => NativeContext.Set<T>().Add(entity);
        public void Update(T entity) => NativeContext.Set<T>().Update(entity);
        public void Delete(T entity) => NativeContext.Set<T>().Remove(entity);
    }
}
