using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Coord.Models
{
   public class Coordinate
    {
        [JsonProperty(PropertyName = "lat")]
        public double Lattitude { get; set; }

        [JsonProperty(PropertyName = "lng")]
        public double Longitude { get; set; }
    }
}
