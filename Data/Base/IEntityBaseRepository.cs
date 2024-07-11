using FilmTicketShop.Models;
using System.Linq.Expressions;

namespace FilmTicketShop.Data.Base
{
	public interface IEntityBaseRepository<T> where T:class, IEntityBase, new()
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includePropertis );
		Task<T> GetByIdAsync(int id);
		Task AddAsync(T entiti);
		Task UpdateAsync(int id, T entity);
		Task DeleteAsync(int id);
	}
}
