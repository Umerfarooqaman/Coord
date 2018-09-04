using Coord;
using Coord.Models;
using CoordGoogleExtended.Model;
using GoogleMapServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoordGoogleExtended
{
    public class CoordGoogleClient : InstanceManager<CoordGoogleClient>
    {
        /// <summary>
        /// share pool to be used in enterprise application
        /// </summary>
        public static Dictionary<string, DirectionsService> DirectionsSharedPool
        {
            set => GoogleMapServices.DirectionsService.SharedPool = value;
        }

        public static string GoogleMapKey { get => GoogleMapServices.GoogleMapCredentials.Key; set => GoogleMapServices.GoogleMapCredentials.Key = value }

        public static string CoordKey
        {
            get => TollsClient.Key;
            set => TollsClient.Key = value;
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

            
            Task<GoogleMapServices.Models.DirectionsResponse> directions = directionsService.GetDirectionsAsync(req);

            CoordGoogleResponse resp = new CoordGoogleResponse() { DirectionsResponse = directions.Result };

            TollsClient tollsClient = string.IsNullOrEmpty(CurrentScope)
                ? TollsClient.GetScopedInstance(CurrentScope)
                : TollsClient.GetSingletonInstance();


            TollsOnRouteRequest tollsOnRouteRequest =
                new TollsOnRouteRequest
                {
                    DepartureTime = req.DepartureTime?.ToString(),
                    Vehicle = req.Vehicle
                };
            List<GoogleMapServices.Models.Step> stepsEnumerable = directions.Result.Routes.First().Legs.SelectMany(d => d.Steps).ToList();
            tollsOnRouteRequest.Steps.AddRange(stepsEnumerable.Select(d => new Step() { EncodedPolyline = d.Polyline.Points, RoadName = d.HtmlInstructions, Duration = d.Duration.Value }));

            Task<TollsCostResponse> sendTollsOnRouteRequestAsync = tollsClient.SendTollsOnRouteRequestAsync(tollsOnRouteRequest);


            resp.TollsCostResponse = sendTollsOnRouteRequestAsync.Result;

            return resp;

        }

        public async Task<CoordGoogleResponse> SendCoordGoogleRequestAsync(CoordGoogleRequest req)
        {
            return SendCoordGoogleRequest(req);
        }








    }
}
