using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riotapp.Dtos
{
    public class ChampionDto
    {
        public InfoDto info { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string key { get; set; }
        public string lore { get; set; }
        public int id { get; set; }
    }
}
