using riotapp.Dtos;
using riotapp.RiotConnector.Requester;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;

namespace riotapp.RiotConnector.Endpoints
{
    public class ChallengersEndPoint : BaseEndPoint
    {
        public ChallengersEndPoint() => Url = @"https://eun1.api.riotgames.com/lol/league/v3/challengerleagues/by-queue/RANKED_SOLO_5x5";
        public async Task<LeagueListDTO> GetPlayersData()
        {
            var data = await client.MakeAsyncRequest(url).ConfigureAwait(false);
            var beforeOrdering= JsonConvert.DeserializeObject<LeagueListDTO>(data);
            // data is unsorted so we order it by points descending
            beforeOrdering.entries = beforeOrdering.entries.OrderByDescending(w => w.leaguePoints).ToList();
            return beforeOrdering;
        }
    }
}
