using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission7_ajames26.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7_ajames26.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieContext _context;

        public HomeController(MovieContext context)
        {
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
            ViewBag.MovieCategories =  _context.MovieCategories.ToList();

            return View(new Movie());
        }

        [HttpPost]
        public IActionResult EnterMovie(Movie movie)
        {
            ViewBag.MovieCategories = _context.MovieCategories.ToList();

            if (ModelState.IsValid)
            {
                _context.Add(movie);
                _context.SaveChanges();
                return View("Confirmation", movie);
            }
            else
            {
                return View(movie);
            }

            
        }

        [HttpGet]
        public async Task<IActionResult> ViewMovies()
        {
            var movies = await _context
                .Movies
                .Include(m => m.MovieCategory)
                .ToListAsync();
            return View(movies);
        }

        [HttpGet]
        public IActionResult EditMovie(int id)
        {
            ViewBag.MovieCategories = _context.MovieCategories.ToList();

            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            return View("EnterMovie", movie);
        }

        [HttpPost]
        public IActionResult EditMovie(Movie movie)
        {
            _context.Update(movie);
            _context.SaveChanges();

            return RedirectToAction("ViewMovies");
        }

        [HttpGet]
        public IActionResult DeleteMovie(int id)
        {
            var movie = _context.Movies.Single(m => m.Id == id);

            return View(movie);
        }

        [HttpPost]
        public IActionResult DeleteMovie(Movie movie)
        {
            _context.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("ViewMovies");
        }
    }
}
