using Microsoft.AspNetCore.Mvc;
using riotapp.Dtos;
using riotapp.RiotConnector.Endpoints;
using riotapp.RiotConnector.Interfaces;
using System.Linq;
using System.Threading.Tasks;


namespace riotapp.Controllers
{
    [Route("api/[controller]")]
    public class ChallengersListController : Controller
    {
        private readonly IChallengersEndPoint getChallengers;
        public ChallengersListController(IChallengersEndPoint getChallengers)
        {
            this.getChallengers = getChallengers;
        }
        [HttpGet("[action]")]
        public async Task<LeagueListDTO> GetChallengers()
        {
            LeagueListDTO players = await getChallengers.ExecuteAsync();
            players.entries = players.entries.OrderByDescending(w => w.leaguePoints).ToList();
            return players;
        }
    }
}
