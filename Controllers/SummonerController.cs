using Microsoft.AspNetCore.Mvc;
using riotapp.Dtos;
using riotapp.RiotConnector.Endpoints;
using riotapp.RiotConnector.Interfaces;
using System.Threading.Tasks;


namespace riotapp.Controllers
{
    [Route("api/[controller]")]
    public class SummonerController : Controller
    {
        private readonly IMatchesEndPoint getMatches;
        private readonly ISummonerEndPoint getSummonerData;

        public SummonerController(ISummonerEndPoint getSummonerData, IMatchesEndPoint getMatches)
        {
            this.getMatches = getMatches;
            this.getSummonerData = getSummonerData;
        }

        [HttpGet("[action]/{name}")]
        public async Task<FullSummonerDto> GetSummonerData(string name)
        {
            SummonerDTO summonerData = await getSummonerData.ExecuteAsync(name);
            MatchListDto matchesData = await getMatches.ExecuteAsync(summonerData.accountId.ToString());
            return new FullSummonerDto()
            {
                summoner = summonerData,
                matches = matchesData
            };
        }
    }
}

