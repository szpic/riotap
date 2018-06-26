using Newtonsoft.Json;
using riotapp.RiotConnector.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace riotapp.RiotConnector.Base
{
    public static class RiotApiClientExtensions
    {
        public static async Task<TResult> GetAsAsync<TResult>(this IRiotApiClient client, string url)
        {
            var data = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<TResult>(data);
        }

        public static async Task<string> GetStringAsync(this IRiotApiClient client, string url)
        {
            using (var response = await client.GetAsync(url).ConfigureAwait(false))
            {
                return await ReadContentAsStringAsync(response).ConfigureAwait(false);
            }
        }

        private static async Task<string> ReadContentAsStringAsync(HttpResponseMessage response)
        {
            using (var content = response.Content)
            {
                return await content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }
    }
}
