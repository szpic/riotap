using Microsoft.AspNetCore.Mvc;
using riotapp.Dtos;
using riotapp.RiotConnector.Endpoints;
using riotapp.RiotConnector.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riotapp.Controllers
{
    [Route("api/[controller]")]
    public class MatchesController :Controller
    {
        private readonly IMatchesEndPoint getMatches;

        public MatchesController(IMatchesEndPoint getMatches) => this.getMatches = getMatches;

        [HttpGet("[action]/{name}")]
        public async Task<MatchListDto> GetMatchesData(string name)
        {
            return await getMatches.ExecuteAsync(name);
        }
    }
}
