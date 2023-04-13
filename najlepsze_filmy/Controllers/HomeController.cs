using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using najlepsze_filmy.Data;
using System.Text.RegularExpressions;
using najlepsze_filmy.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
#nullable disable

namespace najlepsze_filmy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<string> Months = new List<string> { "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień" };

            List<int> MovieQuantity = new List<int>();

            Months.ForEach(x =>
            {
                MovieQuantity.Add(_db.Movies.Where(m => m.Date.Contains(x)).Count());
            });

            ViewBag.Movies = _db.Movies.Count();
            ViewBag.MovieQuantity = MovieQuantity;
            ViewBag.Months = Months;
         
            return View();
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            var Genre = _db.Movies.Where(x => x.Date.Contains(id)).Select(x => x.Genre.Name).Distinct().ToList();

            List<int> GenreQuantity = new List<int>();

            Genre.ForEach(x =>
            {
                GenreQuantity.Add(_db.Movies.Where(m => m.Date.Contains(id) && m.Genre.Name == x.ToString()).Count());
            });

            TempData["Date"] = id;
            ViewBag.Quantity = _db.Movies.Where(x => x.Date.Contains(id)).Select(x => x.Genre.Name).Count();
            ViewBag.Month = id;
            ViewBag.Genre = Genre;
            ViewBag.GenreQuantity = GenreQuantity;

            return View();
        }

        [HttpGet]
        public IActionResult Raiting(string id)
        {
            string Date = TempData["Date"].ToString();
            TempData.Keep();

            var Ratings = _db.Ratings.Select(x => x.Name).ToList();

            List<int> RatingQuantity = new List<int>();

            Ratings.ForEach(x => 
            {
                RatingQuantity.Add(_db.MovieRatings.Where(m => m.Movie.Genre.Name == id && m.Movie.Date.Contains(Date) && m.Rating.Name == x.ToString()).Count());
            });

            ViewBag.Genre = id;
            ViewBag.RatingQuantity = RatingQuantity;
            ViewBag.Ratings = Ratings;

            return View();
        }
    }
}
