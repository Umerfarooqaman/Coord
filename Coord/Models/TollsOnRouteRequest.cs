using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Coord.Models
{
   public class TollsOnRouteRequest
    {

        public TollsOnRouteRequest ()
        {
            Steps=new List<Step>();
        }

        [JsonProperty(PropertyName = "departure_time")]
        public string DepartureTime { get; set; }
        [JsonProperty(PropertyName = "steps")]
        public List<Step> Steps { get; set; }

        [JsonProperty(PropertyName = "vehicle")]
        public Vehicle Vehicle { get; set; }

    }
}
