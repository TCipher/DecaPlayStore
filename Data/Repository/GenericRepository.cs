using DecaPlayStore.Data.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DecaPlayStore.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        protected DbSet<T> _dbSet;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet =  context.Set<T>();
        }

        public async Task AddAsync(T entity)=> await  _dbSet.AddAsync(entity);
        //{
        //    //await _context.Set<T>().AddAsync(entity);
        //    //await _context.SaveChangesAsync();

        //}

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            EntityEntry entityEntry = _dbSet.Entry(entity);
            entityEntry.State = EntityState.Deleted;
           
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                var result = await _dbSet.Include("Albums").SingleAsync(predicate);
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
