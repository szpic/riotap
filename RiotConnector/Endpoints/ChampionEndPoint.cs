using riotapp.Dtos;
using riotapp.RiotConnector.Base;
using riotapp.RiotConnector.Requester;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riotapp.RiotConnector.Endpoints
{
    public class ChampionEndPoint : BaseEndPoint
    {
        public ChampionEndPoint() => Url = @"https://eun1.api.riotgames.com/lol/static-data/v3/champions/1?locale=pl_PL&champData=info&champData=lore&tags=info&tags=lore";

        public async Task<ChampionDto> GetChampionData()
        {
            var data = await client.MakeAsyncRequest(url).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<ChampionDto>(data);
        }
    }
}
