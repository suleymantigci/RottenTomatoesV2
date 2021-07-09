using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RottenTomatoes.Entities;

namespace RottenTomatoes.Service
{
    interface IMovieService
    {
        Task<MovieResponse> GetMovies(string movieName);
        Task<Movie> GetMovie(long id);
    }
}
