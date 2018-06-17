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
            return await endPoint.GetSummonerData(name);
        }
    }
}
