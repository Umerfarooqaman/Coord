using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Coord.Models;

namespace Coord
{
  public static class CoordExtentions
    {

        public static TollsGpsTracesResponse Send(TollsGpsTracesRequest req)
        {
          return  TollsClient.GetSingletonInstance().SendGpsTracesRequest(req);
        }

        public static Task<TollsGpsTracesResponse> SendAsync(TollsGpsTracesRequest req)
        {
            return TollsClient.GetSingletonInstance().SendGpsTracesRequestAsync(req);
        }

    }
}
