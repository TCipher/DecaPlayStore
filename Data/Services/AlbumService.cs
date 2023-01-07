using DecaPlayStore.Core.Domains;
using DecaPlayStore.Data.IRepository;
using DecaPlayStore.Data.IServices;
using Microsoft.EntityFrameworkCore;

namespace DecaPlayStore.Data.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly ApplicationDbContext _context;
        protected DbSet<Genre> _dbSet;
        private readonly IUnitOfWork _unitOfWork;
        public AlbumService(ApplicationDbContext dbContext, IUnitOfWork unitOfWork)
        {
            _context = dbContext;
            _dbSet = dbContext.Set<Genre>();
            _unitOfWork = unitOfWork;
        }

        public Task<Album> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
