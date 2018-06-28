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
    public class MatchesEndPoint : IMatchesEndPoint
    {
        private readonly string baseUrl;
        private readonly IRiotApiClient client;

        public MatchesEndPoint(IRiotApiClient client)
        {
            this.client = client;
            baseUrl = @"https://eun1.api.riotgames.com/lol/match/v3/matchlists/by-account/";
        }

        public Task<MatchListDTO> ExecuteAsync(string accountId)
        {
            return client.GetAsAsync<MatchListDTO>(baseUrl + accountId + "?beginIndex=0&endIndex=10");
        }
    }
}
