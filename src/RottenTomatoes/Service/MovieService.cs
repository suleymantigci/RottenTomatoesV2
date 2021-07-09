using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RottenTomatoes.Dao;
using RottenTomatoes.Entities;

namespace RottenTomatoes.Service
{
    public class MovieService:IMovieService
    {
        public IMovie iMovie;

        public MovieService()
        {
            iMovie = new MovieRepository();
        }

        public Task<MovieResponse> GetMovies(string movieName)
        {
            return iMovie.GetMovies(movieName);
        }

        public Task<Movie> GetMovie(long id)
        {
            return iMovie.GetMovie(id);
        }
    }
}
