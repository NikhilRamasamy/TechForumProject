using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var coustomer = new List<coustomer>
            {
                new coustomer { Name = " coustomer 1"},
                new coustomer { Name = " coustomer 2"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                coustomer = coustomer
            };

            return View(ViewModel);
        }
    } 
}