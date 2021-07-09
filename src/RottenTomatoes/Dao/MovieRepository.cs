using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using NuGet.Protocol.Core.v3;
using RottenTomatoes.Entities;

namespace RottenTomatoes.Dao
{
    public class MovieRepository : IMovie
    {
        public async Task<MovieResponse> GetMovies(string movieName)
        {
            movieName = movieName.Replace(" ", "%20");
            MovieResponse movieResponse = new MovieResponse();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://www.rottentomatoes.com/api/private/v1.0/movies?q=" + movieName))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    movieResponse = JsonConvert.DeserializeObject<MovieResponse>(apiResponse);
                    
                    
                }
            }
            return movieResponse;

        }

        public async Task<Movie> GetMovie(long id)
        {
            Movie movie = new Movie();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://www.rottentomatoes.com/api/private/v1.0/movies/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    apiResponse = apiResponse.Replace("runningTime", "runtime");
                    apiResponse = apiResponse.Replace("mpaaRating", "mpaa_rating");
                    movie = JsonConvert.DeserializeObject<Movie>(apiResponse);
                }
            }

            return movie;
        }
    }
}
