using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.Dtos
{
    public class LeagueListDTO
    {
        public string leagueId { get; set; }
        public string tier { get; set; }
        public List<LeagueItemDTO> entries { get; set; }
        public string queue { get; set; }
        public string name { get; set; }
    }
}
