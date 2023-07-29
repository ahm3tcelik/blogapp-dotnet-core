using System;
using System.Linq.Expressions;
using Domain;

namespace Application.Domain
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		Task<T> Add(T entity);
		Task<T> GetAll(Expression<Func<T, bool>>? filter);
		Task<T> GetBy(Expression<Func<T, bool>>? filter);
		Task<T> GetById(Guid id);
		Task<T> Update(T entity);
		Task<T> Delete(Guid id);
	}
}

