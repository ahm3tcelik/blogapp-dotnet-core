using System;
using System.Linq.Expressions;
using Application.Domain.Common;
using Domain;

namespace Persistence.Domain
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        public Task<TEntity> Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetBy(Expression<Func<TEntity, bool>>? filter)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

