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
        private string BaseAddress = "https://api.coord.co/v1/search/tolling/gps_trace?access_key=";

        public static string Key { get; set; }




        public async Task< TollsGpsTracesResponse> SendGpsTracesRequestAsync(TollsGpsTracesRequest req)
        {
            HttpResponseMessage response = _client.PostAsync(BaseAddress + Key, new StringContent(
               JsonConvert.SerializeObject(req), Encoding.UTF8, "application/json")).Result;

            return JsonConvert.DeserializeObject<TollsGpsTracesResponse>(response.Content.ReadAsStringAsync().Result);

        }

        public TollsGpsTracesResponse SendGpsTracesRequest(TollsGpsTracesRequest req)
        {
            return SendGpsTracesRequestAsync(req).Result;

        }





    }
}
