using System;
using Newtonsoft.Json;

namespace Coord.Models
{
    public class Charges
    {
        [JsonProperty(PropertyName = "amount")]
        public double Amount { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public String Currency { get; set; }


    }
}