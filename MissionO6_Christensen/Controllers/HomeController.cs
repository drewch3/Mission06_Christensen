using Microsoft.AspNetCore.Mvc;
using MissionO6_Christensen.Models; // Ensure this is correctly included
using System.Linq;

namespace MissionO6_Christensen.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieContext _context; // Change MovieDbContext to MovieContext

        public HomeController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        public IActionResult EnterMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("MovieList"); // ✅ Redirects to the Movie List page
            }
            return View(movie);
        }
    }
}