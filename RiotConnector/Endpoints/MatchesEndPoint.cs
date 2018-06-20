using my_new_app.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.RiotConnector.Endpoints
{
    public class MatchesEndPoint : BaseEndPoint
    {
        public MatchesEndPoint() => Url = @"/lol/match/v3/matchlists/by-account/";
        public async Task<MatchListDto> GetMatches(string accountId)
        {
            var data = await client.MakeAsyncRequest(Url + accountId + "?beginIndex=0&endIndex=10").ConfigureAwait(false);
            return JsonConvert.DeserializeObject<MatchListDto>(data);
        }
    }
}
