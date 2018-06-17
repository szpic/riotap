using my_new_app.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.RiotConnector.Endpoints
{
    public class SummonerEndPoint : BaseEndPoint
    { 
        public SummonerEndPoint() => Url = @"https://eun1.api.riotgames.com/lol/summoner/v3/summoners/by-name/";

        public async Task<SummonerDTO> GetSummonerData(string summonerName)
        {
            var data = await client.MakeAsyncRequest(url + summonerName).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<SummonerDTO>(data);
        }
    }
}
