using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riotapp.RiotConnector.Interfaces
{
    public interface IAsyncFunction<TResponse>
    {
        Task<TResponse> ExecuteAsync();
    }

    public interface IAsyncFunction<T, TResponse>
    {
        Task<TResponse> ExecuteAsync(T parameter);
    }
}
