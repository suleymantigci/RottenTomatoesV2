using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RottenTomatoes.Entities
{
    public class MovieResponse
    {
        public MovieResponse()
        {
            _movies = new List<Movie>();
        }

        private int? _total;
        
        [JsonProperty("total")]
        public int? Total
        {
            get { return _total; }
            set { _total = value; }
        }
        private List<Movie> _movies;

        [JsonProperty("movies")]
        public List<Movie> Movies
        {
            get { return _movies; }
            set { _movies = value; }
        }

        private Links _links;

        [JsonProperty("links")]
        public Links Links
        {
            get { return _links; }
            set { _links = value; }
        }
        private string _link_template;

        [JsonProperty("link_template")]
        public string link_template
        {
            get { return _link_template; }
            set { _link_template = value; }
        }



    }
}
