using Microsoft.AspNetCore.Mvc;
using riotapp.Dtos;
using riotapp.RiotConnector.Endpoints;
using riotapp.RiotConnector.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace riotapp.Controllers
{
    [Route("api/[controller]")]
    public class ChampionsListController : Controller
    {
        private readonly IChampionEndPoint getChampions;

        public ChampionsListController(IChampionEndPoint getChampions)
        {
            this.getChampions = getChampions;
        }
        [HttpGet("[action]")]
        public async Task<ChampionDTO> getChampionData()
        {
            return await getChampions.ExecuteAsync();
        }
    }
}
