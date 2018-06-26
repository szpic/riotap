using riotapp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riotapp.RiotConnector.Interfaces
{
    public interface ISummonerEndPoint : IAsyncFunction<string, SummonerDTO>
    {
    }
}
