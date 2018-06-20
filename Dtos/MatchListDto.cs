using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.Dtos
{
    public class MatchListDto
    {
        public List<matchReferenceDto> matches { get; set; }
        public int totalGames { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
    }
}
