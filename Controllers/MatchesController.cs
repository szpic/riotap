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
    public class MatchesController :Controller
    {
        [HttpGet("[action]/{name}")]
        public async Task<MatchListDto> GetMatchesData(string name)
        {
            MatchesEndPoint endPoint = new MatchesEndPoint();
            return await endPoint.GetMatches(name);
        }
    }
}
