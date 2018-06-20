using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.Dtos
{
    public class matchReferenceDto
    {
        public string lane { get; set; }
        public long gameId { get; set; }
        public int champion { get; set; }
        public string platformId { get; set; }
        public long timestamp { get; set; }
        public int queue { get; set; }
        public string role { get; set; }
        public int season { get; set; }
    }
}
