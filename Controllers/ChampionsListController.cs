using Microsoft.AspNetCore.Mvc;
using my_new_app.Dtos;
using my_new_app.RiotConnector.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.Controllers
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
