using Coord.Models;
using System.Threading.Tasks;

namespace Coord
{
    public static class CoordExtentions
    {

        public static TollsCostResponse Send(TollsGpsTracesRequest req)
        {
            return TollsClient.GetSingletonInstance().SendGpsTracesRequest(req);
        }

        public static Task<TollsCostResponse> SendAsync(TollsGpsTracesRequest req)
        {
            return TollsClient.GetSingletonInstance().SendGpsTracesRequestAsync(req);
        }

        public static TollsCostResponse Send(TollsOnRouteRequest req)
        {
            return TollsClient.GetSingletonInstance().SendTollsOnRouteRequest(req);
        }

        public static Task<TollsCostResponse> SendAsync(TollsOnRouteRequest req)
        {
            return TollsClient.GetSingletonInstance().SendTollsOnRouteRequestAsync(req);
        }



    }
}
