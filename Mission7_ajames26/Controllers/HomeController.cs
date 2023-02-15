using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_ajames26.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ajames26.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MovieContext _context;

        public HomeController(ILogger<HomeController> logger, MovieContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bacon()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(Movie movie)
        {
            _context.Add(movie);
            _context.SaveChanges();
            return View("Confirmation", movie);
        }

        [HttpGet]
        public IActionResult ViewMovies()
        {
            var movies = _context.Movies;
            return View(movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
