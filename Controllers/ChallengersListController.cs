using Microsoft.AspNetCore.Mvc;
using riotapp.Dtos;
using riotapp.RiotConnector.Endpoints;
using System.Linq;
using System.Threading.Tasks;


namespace riotapp.Controllers
{
    [Route("api/[controller]")]
    public class ChallengersListController:Controller
    {
        [HttpGet("[action]")]
        public async Task<LeagueListDTO> GetChallengers()
        {
            ChallengersEndPoint endPoint = new ChallengersEndPoint();
            return await endPoint.GetPlayersData();
        }
    }
}
