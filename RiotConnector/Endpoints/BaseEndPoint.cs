using my_new_app.RiotConnector.Requester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.RiotConnector.Endpoints
{
    public class BaseEndPoint
    {
        protected string url;
        protected string Url { get => url; set => url = value; }
        protected RiotApiRequest client = new RiotApiRequest();
    }
}
