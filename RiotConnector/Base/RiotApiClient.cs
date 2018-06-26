using riotapp.RiotConnector.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace riotapp.RiotConnector.Base
{
    public class RiotApiClient : IRiotApiClient
    {
        static Lazy<HttpClient> client = new Lazy<HttpClient>(() =>
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Riot-Token", "RGAPI-638fa374-7649-4e4f-8d53-59d831848b32");
            return client;
        });

        public Task<HttpResponseMessage>GetAsync (string url)
        {
            return client.Value.GetAsync(url);
        }
    }
}
