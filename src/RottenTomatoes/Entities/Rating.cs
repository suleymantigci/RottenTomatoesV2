using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RottenTomatoes.Entities
{
    public class Rating
    {
        private string _critics_rating;
        [JsonProperty("critics_rating")]
        public string Critics_Rating
        {
            get { return _critics_rating; }
            set { _critics_rating = value; }
        }
        private int? _critics_score;
        [JsonProperty("critics_score")]
        public int? Critics_Score
        {
            get { return _critics_score; }
            set { _critics_score = value; }
        }
        private string _audience_rating;
        [JsonProperty("audience_rating")]
        public string Audience_Rating
        {
            get { return _audience_rating; }
            set { _audience_rating = value; }
        }
        private int? _audience_score;
        [JsonProperty("audience_score")]
        public int? Audience_Score
        {
            get { return _audience_score; }
            set { _audience_score = value; }
        }



    }
}
