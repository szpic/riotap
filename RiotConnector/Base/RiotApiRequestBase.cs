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
            var z = new HttpClient();
            using( HttpClient client = new HttpClient())
            {
                return await client.GetAsync(url).ConfigureAwait(false);

            }
        }
    }
}
