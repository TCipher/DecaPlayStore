using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace DecaPlayStore.Controllers
{
    public class StoreController : Controller
    {
        //
        //GET: /Store/
        public string Index()
        {
            return "Hello from store.Indedx() ";
        }


        //
        //GET: /Store/Browse?genre=Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genere = " + genre);
            return message;
        }
    }
}
