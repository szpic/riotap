using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace riotapp.RiotConnector.Interfaces
{ 
    public interface IRiotApiClient
    {
        Task<HttpResponseMessage> GetAsync(string url);
    }
}
