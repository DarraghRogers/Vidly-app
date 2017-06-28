using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMoviess();
            return View(movies);
        }

        public IEnumerable<Movie> GetMoviess()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Jaws!" },
                new Movie {Id = 2, Name = "Warrior" }
            };
        }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customer = new List<Customer>();

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer

            };

            return View(viewModel);
        }

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]//no verbatem string here
        //public ActionResult ByReleaseYear(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}
        ////action will be called when we navagate to movies
        //public ActionResult Index(int? pageIndex, string sortBy)//? to make it nullable
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}