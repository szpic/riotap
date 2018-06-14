using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.Dtos
{
    public class MiniSeriesDTO
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public int target { get; set; }
        public string progress { get; set; }
    }
}
