using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.Logging;
using RottenTomatoes.Entities;

namespace RottenTomatoes.Dao
{
    public interface IMovie
    {
        Task<MovieResponse> GetMovies(string movieName);
        Task<Movie> GetMovie(long id);
    }
}
