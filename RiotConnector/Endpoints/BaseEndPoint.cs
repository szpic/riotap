using riotapp.RiotConnector.Requester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riotapp.RiotConnector.Endpoints
{
    public class BaseEndPoint
    {
        protected string url;
        protected string Url { get => url; set => url = value; }
        protected RiotApiRequest client = new RiotApiRequest();
    }
}
