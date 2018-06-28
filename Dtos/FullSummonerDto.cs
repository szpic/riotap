using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riotapp.Dtos
{
    public class FullSummonerDTO
    {
        public SummonerDTO summoner { get; set; }
        public MatchListDTO matches { get; set; }
    }
}
