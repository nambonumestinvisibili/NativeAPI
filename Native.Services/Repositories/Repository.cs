using Microsoft.EntityFrameworkCore;
using Native.Domain.Models;
using Native.Services.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Native.Services.Repositories
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

        public void Create(T entity) => NativeContext.Set<T>().Add(entity);
        public void Update(T entity) => NativeContext.Set<T>().Update(entity);
        public void Delete(T entity) => NativeContext.Set<T>().Remove(entity);
    }
}
