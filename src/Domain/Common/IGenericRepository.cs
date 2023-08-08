using System;
using System.Linq.Expressions;

namespace BlogApp.Domain
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		Task<T> AddAsync(T entity);
		IAsyncEnumerable<T> GetAll(Expression<Func<T, bool>>? filter);
		Task<T?> GetByAsync(Expression<Func<T, bool>> filter);
		Task<T?> GetByIdAsync(Guid id);
		Task<T> UpdateAsync(T entity);
		Task<T> DeleteAsync(Guid id);
	}
}

