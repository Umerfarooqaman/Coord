using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Coord.Models
{
    public class GpsTrace :Coordinate
    {
        [JsonProperty(PropertyName = "timestamp")]
        public string TimeStamp { get; set; }

      
    }
}
