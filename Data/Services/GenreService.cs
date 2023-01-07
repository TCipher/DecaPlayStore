using DecaPlayStore.Core.Domains;
using DecaPlayStore.Data.IRepository;
using DecaPlayStore.Data.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecaPlayStore.Data.Services
{
    public class GenreService : IGenreService
    {
        private readonly ApplicationDbContext _context;
        protected DbSet<Genre> _dbSet;
        private readonly IUnitOfWork _unitOfWork;
        public GenreService(ApplicationDbContext dbContext, IUnitOfWork unitOfWork)
        {
            _context = dbContext;
            _dbSet = dbContext.Set<Genre>();
            _unitOfWork = unitOfWork;   
        }
        public async Task<List<Genre>>GetAllGenreAsnyc()
        {
            try
            {
                IEnumerable<Genre> genre = await _unitOfWork.genreRepository.GetAllAsync();

                return genre.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<Genre> GetByNameAsync(string genre)
        {
            try
            {
                var result = await _unitOfWork.genreRepository.GetSingleAsync(g => g.Name == genre);
                return result;
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        //public async Task<IEnumerable<Genre>> GetAllGenreAsnyc(params System.Linq.Expressions.Expression<System.Func<Genre, object>>[] includeProperties)
        //{
        //    IQueryable<Genre> query = _dbSet;
        //    query = includeProperties.Aggregate(query,(current, includeProperty) => current.Include(includeProperty));
        //    return await query.ToListAsync();
        //}
    }
}
