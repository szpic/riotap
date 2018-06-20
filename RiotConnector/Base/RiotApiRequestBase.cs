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
                client.DefaultRequestHeaders.Add("X-Riot-Token", "RGAPI-2fdeefe1-6312-4731-a3c6-bc8d128d7f33");
                return await client.GetAsync(url).ConfigureAwait(false);

            }
        }
    }
}
