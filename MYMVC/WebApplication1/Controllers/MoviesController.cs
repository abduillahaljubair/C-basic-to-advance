using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        /*public IActionResult List()
        {
            return View();
        }*/

        /* public IActionResult Index()
         {
             return View("List");
         }*/
        public IActionResult List()
        {
            Movie movie = GetMovie();
            return View(movie);
        }

        private Movie GetMovie()
        {
            return new Movie
            {
                id = 1,
                MovieName = "loot"
            };
        }
    }
}
