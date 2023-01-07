using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DecaPlayStore.Data.Base
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
       
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);

        Task DeleteAsync(int id);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);

    }
}
