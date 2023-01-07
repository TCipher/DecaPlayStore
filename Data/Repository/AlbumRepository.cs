using DecaPlayStore.Core.Domains;
using DecaPlayStore.Data.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DecaPlayStore.Data.Repository
{
    public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
    {
        private readonly ApplicationDbContext _context;
        public AlbumRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

      
        
    }
}
