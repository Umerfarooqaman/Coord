using Coord.Models;
using CoordGoogleExtended.Model;
using GoogleMapServices.Models;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace CoordGoogleExtended
{
    public static class CoordGoogleExtentions
    {

        public static double CashTolls(this TollsCostResponse tollsCostResponse)
        {
            try
            {
                return tollsCostResponse.Sum(d => d.Price.Where(price => price.Payment.Type.Equals("Cash", StringComparison.CurrentCultureIgnoreCase)).Sum(f => f.Charges.Amount));

            }
            catch (Exception)
            {

                return 0;
            }
        }

        public static CoordGoogleResponse Send(this DirectionsRequest req, Vehicle v, string serviceScope = "")
        {
            CoordGoogleRequest coordGoogleRequest = JsonConvert.DeserializeObject<CoordGoogleRequest>(JsonConvert.SerializeObject(req));
            coordGoogleRequest.Vehicle = v;
            return coordGoogleRequest.Send(serviceScope);
        }


        public static CoordGoogleResponse Send(this CoordGoogleRequest req, string serviceScope = "")
        {
            if (string.IsNullOrEmpty(serviceScope))
            {
                return CoordGoogleClient.GetSingletonInstance().SendCoordGoogleRequest(req);
            }
            else
            {
                return CoordGoogleClient.GetScopedInstance(serviceScope).SendCoordGoogleRequest(req);
            }
        }


    }
}
