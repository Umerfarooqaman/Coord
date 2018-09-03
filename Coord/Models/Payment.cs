using Newtonsoft.Json;

namespace Coord.Models
{
    public class Payment
    {
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}