using System;
using System.Linq.Expressions;
using BlogApp.Domain;
using Microsoft.EntityFrameworkCore;
using BlogApp.Infrastructure.Persistence.Exceptions;

namespace BlogApp.Infrastructure.Persistence.Domain
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly AppDbContext dbContext;
        private readonly DbSet<TEntity> dbSet;

        public GenericRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteAsync(Guid id)
        {

            var entity = await dbSet.FindAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                return entity;
            }
            throw new EntityNotFoundException($"{typeof(TEntity).FullName} with ID '{id}' not found.");
        }

        public IAsyncEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter)
        {
            if (filter == null)
            {
                return dbSet.AsAsyncEnumerable();
            }
            return dbSet.Where(filter).AsAsyncEnumerable();
        }

        public async Task<TEntity?> GetByAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await dbSet.FirstOrDefaultAsync(filter);
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var updatedEntry = dbSet.Entry(entity);
            updatedEntry.State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return entity;
        }
    }
}

 