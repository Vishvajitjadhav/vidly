using Microsoft.AspNetCore.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var movie = new Movie() { Id = 1, Name = "Natasamrat" };
            return View(movie);
        }
    }
}
