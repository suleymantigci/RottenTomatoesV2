using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RottenTomatoes.Entities
{
    public class ReleaseDate
    {
        private DateTime _theaterDateTime;
        [JsonProperty("theater")]
        public DateTime TheaterDateTime
        {
            get { return _theaterDateTime; }
            set { _theaterDateTime = value; }
        }
        private DateTime _dvDateTime;
        [JsonProperty("dvd")]
        public DateTime DvDateTime
        {
            get { return _dvDateTime; }
            set { _dvDateTime = value; }
        }


    }
}
