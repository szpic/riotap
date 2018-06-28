using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riotapp.Dtos
{
    public class MatchListDTO
    {
        public List<matchReferenceDTO> matches { get; set; }
        public int totalGames { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
    }
}
