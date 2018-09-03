using System;
using System.Collections.Generic;
using System.Text;
using Coord.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Coord.UnitTest
{
    [TestClass]
   public class TollsOnRouteTest
    {
        [TestMethod]
        public void TollsOnRouteWithExampleTest()
        {

            TollsOnRouteRequest request = JsonConvert.DeserializeObject<TollsOnRouteRequest>("{ \"departure_time\": \"2017-07-28T17:39:43.611Z\", \"steps\": [ { \"encoded_polyline\": \"iywaHjemiVCDEFEHMP\", \"road_name\": \"Lake Washington Blvd E\" }, { \"encoded_polyline\": \"gzwaHtfmiVCAWLYFUAs@S{@a@e@e@}@kAo@cAWi@g@eBm@gCcA{C]q@u@kAm@_Ag@q@s@gAg@aAUcAGgAA_CA_@JyDRiI`Bql@p@kHtB{Rv@oHfAcNvI}eAvOkkBbEwZlAoIp@{Et@cKhAmN\", \"road_name\": \"WA-520 E\" }, { \"encoded_polyline\": \"s|vaHnm`iVXwAh@aFPwBD{@H{ABg@@e@?Q?QAWAQ@IBQBIDKHKj@ONKLAN?^AF?\", \"road_name\": \"84th Ave NE\" } ], \"vehicle\": { \"axles\": 2 } }");

            var tollsGpsTracesResponse = CoordExtentions.Send(request);

            Assert.IsNotNull(tollsGpsTracesResponse);

        }




    }
}
