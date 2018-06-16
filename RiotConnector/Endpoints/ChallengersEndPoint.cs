using my_new_app.Dtos;
using my_new_app.RiotConnector.Requester;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace my_new_app.RiotConnector.Endpoints
{
    public class ChallengersEndPoint
    {
        protected string url = @"https://eun1.api.riotgames.com/lol/league/v3/challengerleagues/by-queue/RANKED_SOLO_5x5";
        protected RiotApiRequest client = new RiotApiRequest();

        public async Task<LeagueListDTO> GetPlayersData()
        {
            var data = await client.MakeAsyncRequest(url).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<LeagueListDTO>(data);
        }
    }
}
