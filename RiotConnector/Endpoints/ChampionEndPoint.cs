using riotapp.Dtos;
using riotapp.RiotConnector.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using riotapp.RiotConnector.Interfaces;

namespace riotapp.RiotConnector.Endpoints
{
    public class ChampionEndPoint : IChampionEndPoint
    {
        private readonly string baserUrl;
        private readonly IRiotApiClient client;

        public ChampionEndPoint(IRiotApiClient client)
        {
            this.client = client;
            this.baserUrl = @"https://eun1.api.riotgames.com/lol/static-data/v3/champions/1?locale=pl_PL&champData=info&champData=lore&tags=info&tags=lore";
        }
        
        public Task<ChampionDTO> ExecuteAsync()
        {
            return client.GetAsAsync<ChampionDTO>(baserUrl);
        }
    }
}
