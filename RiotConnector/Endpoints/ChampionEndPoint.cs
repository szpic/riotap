using my_new_app.Dtos;
using my_new_app.RiotConnector.Base;
using my_new_app.RiotConnector.Requester;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.RiotConnector.Endpoints
{
    public class ChampionEndPoint
    {
        protected string url = @"https://eun1.api.riotgames.com/lol/static-data/v3/champions/1?locale=pl_PL&champData=info&champData=lore&tags=info&tags=lore";
        protected RiotApiRequest client = new RiotApiRequest();

        public async Task<ChampionDto> GetChampionData()
        {
            var data = await client.MakeAsyncRequest(url).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<ChampionDto>(data);
        }
    }
}
