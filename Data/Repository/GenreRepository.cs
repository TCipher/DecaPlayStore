using DecaPlayStore.Core.Domains;
using DecaPlayStore.Data.IRepository;

namespace DecaPlayStore.Data.Repository
{
    public class GenreRepository:  GenericRepository<Genre>, IGenreRepository
    {
        private  readonly ApplicationDbContext _context; 
        public GenreRepository(ApplicationDbContext context):base(context)
        {
            _context = context; 
        }
    }

}
