using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coord.Models
{
    public class Step
    {

        [JsonProperty(PropertyName = "duration_s")]
        public int Duration { get; set; }

        [JsonProperty(PropertyName = "encoded_polyline")]
        public string EncodedPolyline { get; set; }

        [JsonProperty(PropertyName = "polyline")]
        public List<GpsTrace> Polyline { get; set; }

        [JsonProperty(PropertyName = "road_name")]
        public string RoadName { get; set; }

    }
}