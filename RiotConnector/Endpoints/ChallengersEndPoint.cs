using riotapp.Dtos;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using riotapp.RiotConnector.Interfaces;
using riotapp.RiotConnector.Base;

namespace riotapp.RiotConnector.Endpoints
{
    public class ChallengersEndPoint : IChallengersEndPoint
    {

        private readonly string baseUrl;
        private readonly IRiotApiClient client;

        public ChallengersEndPoint(IRiotApiClient client)
        {
            this.client = client;
            baseUrl = @"https://eun1.api.riotgames.com/lol/league/v3/challengerleagues/by-queue/RANKED_SOLO_5x5";
        }
          
        public Task<LeagueListDTO> ExecuteAsync()
        {
            return client.GetAsAsync<LeagueListDTO>(baseUrl);
        }
    }
}
