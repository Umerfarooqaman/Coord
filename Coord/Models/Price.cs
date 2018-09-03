using Newtonsoft.Json;

namespace Coord.Models
{
    public class Price
    {
        [JsonProperty(PropertyName = "maximum_price")]
        public Charges MaximumPrice { get; set; }
        [JsonProperty(PropertyName = "minimum_price")]
        public Charges MinimumPrice { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public Payment Payment { get; set; }

        [JsonProperty(PropertyName = "price")]
        public Charges Charges { get; set; }

        [JsonProperty(PropertyName = "vehicle")]
        public Vehicle Vehicle { get; set; }


    }
}