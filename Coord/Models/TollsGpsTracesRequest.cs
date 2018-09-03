using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Coord.Models
{
   public class TollsGpsTracesRequest
    {
        [JsonProperty(PropertyName = "locations")]
        public List<GpsTrace> GpsTraces { get; set; } = new List<GpsTrace>();

        [JsonProperty(PropertyName = "vehicle")]
        public Vehicle Vehicle { get; set; } =new Vehicle();



        [JsonIgnore]
        public int Axels { get=>Vehicle.Axles; set=>Vehicle.Axles=value; }

        [JsonIgnore]
        public  IList<GpsTrace> Locations{ get => GpsTraces; }

    }
}
