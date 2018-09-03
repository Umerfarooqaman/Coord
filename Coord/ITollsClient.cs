using System.Threading.Tasks;
using Coord.Models;

namespace Coord
{
    public interface ITollsClient
    {
        TollsCostResponse SendGpsTracesRequest(TollsGpsTracesRequest req);
        Task<TollsCostResponse> SendGpsTracesRequestAsync(TollsGpsTracesRequest req);
        TollsCostResponse SendTollsOnRouteRequest(TollsOnRouteRequest req);
        Task<TollsCostResponse> SendTollsOnRouteRequestAsync(TollsOnRouteRequest req);
    }
}