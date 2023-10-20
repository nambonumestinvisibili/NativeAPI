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
using Native.Service.Repositories;

namespace Native.Repositories.Repositories
{
    internal class Repository<T> : IRepository<T> where T : Entity
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

        public async Task<T> GetByGuidAsync(Guid guid)
        {
            return await NativeContext.Set<T>()
                .GetByGuidAsync(guid);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            T? result = await NativeContext.Set<T>().SingleOrDefaultAsync(item => item.Id == id);
            ExceptionExtensions.ThrowNotFoundIfNull<T>(result, id);
            return result!;
        }

        public async Task<IEnumerable<T>> GetAllOfGuids(ICollection<Guid> guids)
        {
            var resources = await FindAll(trackChanges: false)
                .Where(item => guids.Contains(item.Guid))
                .ToListAsync();

            if (resources.Count == guids.Count)
            {
                return resources;
            }

            var guidsThatWereNotFound = guids.Where(guid =>
                !resources.Select(interest => interest.Guid).Contains(guid));

            ExceptionExtensions.ThrowNotFoundFor<Interest>(guids: guidsThatWereNotFound);
            return Enumerable.Empty<T>();
        }

        public async Task<T> GetByGuidWithIncludesAsync(Guid guid, params Expression<Func<T, object>>[] includes)
        {
            T? result = await NativeContext.Set<T>()
                .IncludeMultiple(includes)
                .SingleOrDefaultAsync(item => item.Guid == guid);
            ExceptionExtensions.ThrowNotFoundIfNull<T>(result, guid);
            return result!;
        }

        public void Create(T entity) => NativeContext.Set<T>().Add(entity);

        public async Task<T> CreateIfDoesntExist(T entity)
        {
            var entityFromDb = await NativeContext.Set<T>().FirstOrDefaultAsync(e => e.Id == entity.Id);
            if (entityFromDb == null)
            {
                NativeContext.Set<T>().Add(entity);
                await NativeContext.SaveChangesAsync();
                return entity;
            }
            return entityFromDb;
        }

        public void Update(T entity) => NativeContext.Set<T>().Update(entity);
        public void Delete(T entity) => NativeContext.Set<T>().Remove(entity);
    }

    public static class RepositoryExtensions
    {
        public static IQueryable<T> IncludeMultiple<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes) 
            where T : class
        {
            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return query;
        }

        public static async Task<T> GetByGuidAsync<T>(this IQueryable<T> query,  Guid guid) where T : Entity
        {
            var result = await query.SingleOrDefaultAsync(item => item.Guid == guid);
            ExceptionExtensions.ThrowNotFoundIfNull<T>(result, guid);
            return result!;
        }
    }
}
