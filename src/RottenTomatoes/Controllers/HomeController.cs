using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RottenTomatoes.Entities;
using RottenTomatoes.Service;

namespace RottenTomatoes.Controllers
{
    public class HomeController : Controller
    {
        SearchText searchText = SearchText.Instance;
        public IActionResult Index()
        {
            
            
            ViewBag.search = searchText.GetList();
            
            return View(searchText.GetList());
        }
        [HttpPost]
        public IActionResult GetIndex(string movieName)
        {
            searchText.AddList(movieName);
            ViewBag.search = searchText.GetList();
            IMovieService iMovieService = new MovieService();
            Task<MovieResponse> movieResponse = iMovieService.GetMovies(movieName);
            return View(movieResponse);
        }

        public IActionResult GetDetail(int id)
        {
            
            ViewBag.search = searchText.GetList();
            IMovieService iMovieService = new MovieService();
            Task<Movie> movie = iMovieService.GetMovie(id);
            ViewBag.Title = movie.Result.Title;
            return View(movie);
        }
    }
}
