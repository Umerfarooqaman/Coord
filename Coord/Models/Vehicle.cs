using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Coord.Models
{
  public  class Vehicle
    {
        [JsonProperty(PropertyName = "axles")]
        public int Axles { get; set; }

        [JsonProperty("min_occupany")]
        public int MinOccupany { get; set; }

        [JsonProperty(PropertyName = "detail_url")]
        public string DetailUrl { get; set; }

        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        [JsonProperty(PropertyName = "motorcycle")]
        public bool Motorcycle { get; set; }
    }
}
