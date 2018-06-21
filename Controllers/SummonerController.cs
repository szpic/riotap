using Microsoft.AspNetCore.Mvc;
using my_new_app.Dtos;
using my_new_app.RiotConnector.Endpoints;
using System.Linq;
using System.Threading.Tasks;


namespace my_new_app.Controllers
{
    [Route("api/[controller]")]
    public class SummonerController : Controller
    {
        [HttpGet("[action]/{name}")]
        public async Task<FullSummonerDto> GetSummonerData(string name)
        {
            SummonerEndPoint endPoint = new SummonerEndPoint();
            SummonerDTO summonerData=  await endPoint.GetSummonerData(name);
            MatchesEndPoint endPoint2 = new MatchesEndPoint();
            MatchListDto matchesData =  await endPoint2.GetMatches(summonerData.accountId.ToString());
            return await TestMethod(summonerData, matchesData);
        }
        public async Task<FullSummonerDto> TestMethod(SummonerDTO summonerData, MatchListDto matchData)
        {
            return await Task.Run(() => {
                return new FullSummonerDto
                {
                    summoner = summonerData,
                    matches = matchData
                };
            });
        }
    }
}

