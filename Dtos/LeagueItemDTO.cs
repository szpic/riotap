using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.Dtos
{
    public class LeagueItemDTO
    {
        public string rank { get; set; }
        public bool hotStreak { get; set; }
        public MiniSeriesDTO miniSeries { get; set; }
        public int wins { get; set; }
        public bool veteran { get; set; }
        public int losses { get; set; }
        public bool freshBlood { get; set; }
        public string playerOrTeamName { get; set; }
        public bool inactive { get; set; }
        public int leaguePoints { get; set; }
    }
}
