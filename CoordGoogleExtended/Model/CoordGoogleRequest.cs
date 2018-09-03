using System;
using System.Collections.Generic;
using System.Text;
using Coord.Models;
using GoogleMapServices.Models;

namespace CoordGoogleExtended.Model
{
   public class CoordGoogleRequest :DirectionsRequest
    {
        public Vehicle Vehicle { get; set; }


        
    }
}
