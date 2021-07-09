using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RottenTomatoes.Entities
{
    public class Links
    {
        private string _self;

        [JsonProperty("self")]
        public string Self
        {
            get { return _self; }
            set { _self = value; }
        }
        public void SetLinks(Links links)
        {
            _self = links._self;
            _next = links._next;
            _prev = links._prev;
        }
        private string _next;
        [JsonProperty("next")]
        public string Next
        {
            get { return _next; }
            set { _next = value; }
        }

        private string _prev;
        [JsonProperty("prev")]
        public string Prev
        {
            get { return _prev; }
            set { _prev = value; }
        }
        
    }
}
