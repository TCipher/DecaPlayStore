using DecaPlayStore.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DecaPlayStore.Data.IServices
{
    public interface IGenreService
    {
        Task<List<Genre>> GetAllGenreAsnyc();
        Task<Genre> GetByNameAsync(string name);
        //Task<IEnumerable<Genre>> GetByNameAsync(params Expression<Func<Genre, object>>[] includeProperties);
    }
}
