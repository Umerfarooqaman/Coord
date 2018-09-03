using System.Threading.Tasks;
using Coord.Models;

namespace Coord
{
    public interface ITollsClient
    {
        TollsGpsTracesResponse SendGpsTracesRequest(TollsGpsTracesRequest req);
        Task<TollsGpsTracesResponse> SendGpsTracesRequestAsync(TollsGpsTracesRequest req);
    }
}