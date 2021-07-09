using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RottenTomatoes.Entities
{
    public class Poster
    {
        private String _thumbnail;
        [JsonProperty("thumbnail")]
        public String Thumbnail
        {
            get { return _thumbnail; }
            set { _thumbnail = value; }
        }
        private String _detailed;
        [JsonProperty("detailed")]
        public String Detailed
        {
            get { return _detailed; }
            set { _detailed = value; }
        }
        private String _original;
        [JsonProperty("original")]
        public String Original
        {
            get { return _original; }
            set { _original = value; }
        }
        private String _profile;
        [JsonProperty("profile")]
        public String Profile
        {
            get { return _profile; }
            set { _profile = value; }
        }


    }
}
