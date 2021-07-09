using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RottenTomatoes.Entities
{
    public class Movie
    {
        private long? _id;

        [JsonProperty("id")]
        public long? Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private String _title;

        [JsonProperty("title")]
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }


        private String _synopsis;

        [JsonProperty("synopsis")]
        public String Synopsis
        {
            get { return _synopsis; }
            set { _synopsis = value; }
        }
        

        private int? _year;

        [JsonProperty("year")]
        public int? Year
        {
            get { return _year; }
            set { _year = value; }
        }


        private ReleaseDate _releaseDate;

        [JsonProperty("release_dates")]
        public ReleaseDate ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }
        
        private Poster _poster;
        [JsonProperty("posters")]
        public Poster Poster
        {
            get { return _poster; }
            set { _poster = value; }
        }
        private String _studio;
        [JsonProperty("studio")]
        public String Studio
        {
            get { return _studio; }
            set { _studio = value; }
        }
        private string _mpaaRating;
        [JsonProperty("mpaa_rating")]
        public string Mpaa_Rating
        {
            get { return _mpaaRating; }
            set { _mpaaRating = value; }
        }
        private int? _runtime;
        [JsonProperty("runtime")]
        public int? Runtime
        {
            get { return _runtime; }
            set { _runtime = value; }
        }
        private Rating _rating;
        [JsonProperty("ratings")]
        public Rating Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }



    }
}
