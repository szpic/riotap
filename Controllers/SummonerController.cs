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
        public async Task<SummonerDTO> GetSummonerData(string name)
        {
            SummonerEndPoint endPoint = new SummonerEndPoint();
            Task<SummonerDTO> data =  endPoint.GetSummonerData(name);
            var readed = await data;
            MatchesEndPoint endPoint2 = new MatchesEndPoint();
            var data2 = endPoint2.GetMatches(data.Result.accountId.ToString());
            var readed2 = await data2;
            return await TestMethod();
        }
        public async Task<SummonerDTO> TestMethod()
        {
            return await Task.Run(() => { return new SummonerDTO { name = "testName", summonerLevel = 123, accountId = 1, id = 2, profileIconId = 3 }; });
        }
    }
}

