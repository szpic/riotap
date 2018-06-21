using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.Dtos
{
    public class FullSummonerDto
    {
        public SummonerDTO summoner { get; set; }
        public MatchListDto matches { get; set; }
    }
}
