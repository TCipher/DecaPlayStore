using System;

namespace DecaPlayStore.Data.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenreRepository genreRepository { get; }

        void SaveChanges();

        void BeginTransaction();


        void Rollback();
    }
}
