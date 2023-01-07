using DecaPlayStore.Core.Domains;

namespace DecaPlayStore.Data.IServices
{
    public interface IAlbumService
    {
        Task<Album> GetByNameAsync(string name);
    }
}
