using DecaPlayStore.Data.IRepository;
using DecaPlayStore.Data.Repository;
using System;

namespace DecaPlayStore.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private bool _disposed;
        private IGenreRepository _genreRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
          
        }
    
        public IGenreRepository genreRepository =>
            _genreRepository ??= new GenreRepository(_context);

       
        public void BeginTransaction()
        {
            _disposed = false;
        }
        protected virtual void Dispose(bool disposing)
        {

            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
