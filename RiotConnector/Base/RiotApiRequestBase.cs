using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace my_new_app.RiotConnector.Base
{
    public class RiotApiRequestBase
    {
        protected async Task<HttpResponseMessage> MakeRequest(string url)
        {
            using( HttpClient client = new HttpClient())
            {
                //later this may be moved elsewhere ;)
                client.DefaultRequestHeaders.Add("X-Riot-Token", "RGAPI-03f3452f-8f19-4889-96b0-be8ebd290b32");
                return await client.GetAsync(url).ConfigureAwait(false);

            }
        }
    }
}
