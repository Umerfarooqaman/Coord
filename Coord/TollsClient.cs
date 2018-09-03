using Coord.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Coord
{
    public class TollsClient : InstanceManager<TollsClient>, ITollsClient
    {
        private HttpClient _client = new HttpClient();
        private string BaseAddress = "https://api.coord.co/v1";

        public static string Key { get; set; }




        public async Task< TollsCostResponse> SendGpsTracesRequestAsync(TollsGpsTracesRequest req)
        {
            HttpResponseMessage response = _client.PostAsync($"{BaseAddress}/search/tolling/gps_trace?access_key={Key}", new StringContent(
               JsonConvert.SerializeObject(req), Encoding.UTF8, "application/json")).Result;

            return JsonConvert.DeserializeObject<TollsCostResponse>(response.Content.ReadAsStringAsync().Result);

        }

        public TollsCostResponse SendGpsTracesRequest(TollsGpsTracesRequest req)
        {
            return SendGpsTracesRequestAsync(req).Result;

        }


        public async Task<TollsCostResponse> SendTollsOnRouteRequestAsync(TollsOnRouteRequest req)
        {
            HttpResponseMessage response = _client.PostAsync($"{BaseAddress}/search/tolling/route?access_key={Key}", new StringContent(
                JsonConvert.SerializeObject(req), Encoding.UTF8, "application/json")).Result;

            var result = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<TollsCostResponse>(result);

        }

        public TollsCostResponse SendTollsOnRouteRequest(TollsOnRouteRequest req)
        {
            return SendTollsOnRouteRequestAsync(req).Result;

        }

    }
}
