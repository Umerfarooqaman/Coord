using System;
using System.Collections.Generic;
using System.Text;
using Coord.Models;
using GoogleMapServices.Models;

namespace CoordGoogleExtended.Model
{
    public class CoordGoogleResponse
    {

        public DirectionsResponse DirectionsResponse { get; set; }

        public TollsCostResponse TollsCostResponse { get; set; }



    }
}
