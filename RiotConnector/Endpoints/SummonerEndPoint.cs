using riotapp.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using riotapp.RiotConnector.Interfaces;
using riotapp.RiotConnector.Base;

namespace riotapp.RiotConnector.Endpoints
{
    public class SummonerEndPoint : ISummonerEndPoint
    {
        private readonly string baseUrl;
        private readonly IRiotApiClient client;
        public SummonerEndPoint(IRiotApiClient client)
        {
            this.client = client;
            baseUrl = @"https://eun1.api.riotgames.com/lol/summoner/v3/summoners/by-name/";
        }

        public Task<SummonerDTO> ExecuteAsync(string summonerName)
        {
            return client.GetAsAsync<SummonerDTO>(baseUrl + summonerName);
        }

    }
}
