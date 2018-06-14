using Microsoft.AspNetCore.Mvc;
using my_new_app.Dtos;
using my_new_app.RiotConnector.Endpoints;
using System.Linq;
using System.Threading.Tasks;


namespace my_new_app.Controllers
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
