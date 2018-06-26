using Microsoft.AspNetCore.Mvc;
using riotapp.Dtos;
using riotapp.RiotConnector.Endpoints;
using System.Linq;
using System.Threading.Tasks;

namespace riotapp.Controllers
{
    [Route("api/[controller]")]
    public class ChampionsListController : Controller
    {
        [HttpGet("[action]")]
        public async Task<ChampionDto> getChampionData()
        {
            ChampionEndPoint endpoint = new ChampionEndPoint();
            return await endpoint.GetChampionData();
        }
    }
}
