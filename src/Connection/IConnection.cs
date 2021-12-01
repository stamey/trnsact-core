using System.Net.Http;
using System.Threading.Tasks;

namespace trnsACT.Core.Connection
{
    public interface IConnection
    {
        HttpClient Client { get; }
        Task<Response> Connect<Response, Request>(Request request, string apiPath);
    }
}
