using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Coord;
using Coord.Models;
using CoordGoogleExtended.Model;
using GoogleMapServices;

namespace CoordGoogleExtended
{
   public class CoordGoogleClient :InstanceManager<CoordGoogleClient>
    {
        /// <summary>
        /// share pool to be used in enterprise application
        /// </summary>
        public static Dictionary<string, DirectionsService> DirectionsSharedPool
        {
            set => GoogleMapServices.DirectionsService.SharedPool = value;
        }



        /// <summary>
        /// share pool to be used in enterprise application
        /// </summary>
        public static Dictionary<string, Coord.TollsClient> CoordSharedPool
        {
            set => Coord.TollsClient.SharedPool = value;
        }


      
        public CoordGoogleResponse SendCoordGoogleRequest(CoordGoogleRequest req)
        {
            DirectionsService directionsService = string.IsNullOrEmpty(CurrentScope)
                ? DirectionsService.GetScopedInstance(CurrentScope)
                : DirectionsService.GetSingletonInstance();

            TollsClient tollsClient = string.IsNullOrEmpty(CurrentScope)
                ? TollsClient.GetScopedInstance(CurrentScope)
                : TollsClient.GetSingletonInstance();

           var directions= directionsService.GetDirectionsAsync(req);

            //populate coord request

            TollsOnRouteRequest tollsOnRouteRequest =new TollsOnRouteRequest();

            var sendTollsOnRouteRequestAsync = tollsClient.SendTollsOnRouteRequestAsync(tollsOnRouteRequest);




            return new CoordGoogleResponse(){DirectionsResponse = directions.Result,TollsCostResponse = sendTollsOnRouteRequestAsync.Result};

        }

        public async Task<CoordGoogleResponse> SendCoordGoogleRequestAsync(CoordGoogleRequest req)
        {
            return SendCoordGoogleRequest(req);
        }








    }
}
