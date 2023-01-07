using DecaPlayStore.Core.Domains;
using DecaPlayStore.Data;
using DecaPlayStore.Data.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DecaPlayStore.Controllers
{
    public class StoreController : Controller
    {
        private readonly IGenreService _genreService;
        private readonly IAlbumService _albumService;
        public StoreController(IGenreService genreService, IAlbumService albumService)
        {
            _genreService = genreService;
            _albumService = albumService;
        }
        //GET: /Store/
        public async Task<IActionResult> Index()
        {
            try
            {
                var genre =  await  _genreService.GetAllGenreAsnyc();
                return View(genre);
            }
            catch (System.Exception)
            {

                throw;
            }
           
           
        }


        //
        //GET: /Store/Browse?genre=Disco
        public async Task<ActionResult> Browse(string genre)
        {

            try
            {
                var genreModel = await _genreService.GetByNameAsync(genre);
                //.Single(g => g.Name == genre);
                return View(genreModel);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public IActionResult Details(int id)
        {
            var album = new Album { Title = "Common Person " + id };
            return View(album);
        }
    }
}
