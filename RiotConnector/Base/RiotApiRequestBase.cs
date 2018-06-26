using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace riotapp.RiotConnector.Base
{
    public class RiotApiRequestBase
    {
        protected async Task<HttpResponseMessage> MakeRequest(string url)
        {
            using( HttpClient client = new HttpClient())
            {
                //later this may be moved elsewhere ;)
                client.DefaultRequestHeaders.Add("X-Riot-Token", "RGAPI-638fa374-7649-4e4f-8d53-59d831848b32");
                return await client.GetAsync(url).ConfigureAwait(false);

            }
        }
    }
}
