using riotapp.RiotConnector.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace riotapp.RiotConnector.Requester
{
    public class RiotApiRequest : RiotApiRequestBase
    {
        public async Task<string> MakeAsyncRequest(string url)
        {
            using (var response = await MakeRequest(url).ConfigureAwait(false))
            {
                return await GetResponseContentAsync(response).ConfigureAwait(false);
            }
        }

        protected async Task<string> GetResponseContentAsync(HttpResponseMessage response)
        {
            using (response)
            using (var content = response.Content)
            {
                return await content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }
    }
}
