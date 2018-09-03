using Newtonsoft.Json;
using System.Collections.Generic;

namespace Coord.Models
{
    public class TollsCostResponse : List<TollsCostResponseObject>
    {
    }

    public class TollsCostResponseObject
    {
        [JsonProperty(PropertyName = "checkpoints")]
        public List<CheckPoint> CheckPoints { get; set; }

        [JsonProperty(PropertyName = "estimated_cross_time")]
        public string EstimatedCrossTime { get; set; }

        [JsonProperty(PropertyName = "dynamic")]
        public bool Dynamic { get; set; }

        [JsonProperty(PropertyName = "optional")]
        public bool Optional { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "prices")]
        public List<Price> Price { get; set; }

        [JsonProperty(PropertyName = "roadway_name")]
        public string RoadWayName { get; set; }
    }
}
