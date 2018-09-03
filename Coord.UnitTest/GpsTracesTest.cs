using Coord.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Coord.UnitTest
{
    [TestClass]
    public class GpsTracesTest
    {
        [TestMethod]
        public void GpsTracesWithSampleRequest()
        {

            TollsClient.Key = "Your_Api_Key";

            TollsGpsTracesRequest request = JsonConvert.DeserializeObject<TollsGpsTracesRequest>(
                "{ \"locations\": [ { \"timestamp\": \"2017-07-28T17:39:00.000Z\", \"lat\": 47.28348, \"lng\": -122.56066 }, { \"timestamp\": \"2017-07-28T17:39:30.000Z\", \"lat\": 47.28154, \"lng\": -122.56069 }, { \"timestamp\": \"2017-07-28T17:40:00.000Z\", \"lat\": 47.28000, \"lng\": -122.56075 }, { \"timestamp\": \"2017-07-28T17:40:30.000Z\", \"lat\": 47.27901, \"lng\": -122.56081 }, { \"timestamp\": \"2017-07-28T17:41:00.000Z\", \"lat\": 47.27900, \"lng\": -122.56081 }, { \"timestamp\": \"2017-07-28T17:41:30.000Z\", \"lat\": 47.27831, \"lng\": -122.56082 }, { \"timestamp\": \"2017-07-28T17:42:00.000Z\", \"lat\": 47.27823, \"lng\": -122.56082 }, { \"timestamp\": \"2017-07-28T17:42:30.000Z\", \"lat\": 47.27798, \"lng\": -122.56082 } ], \"vehicle\": { \"axles\": 2 } }");

            var tollsGpsTracesResponse = CoordExtentions.Send(request);

            Assert.IsNotNull(tollsGpsTracesResponse);

        }
    }
}
