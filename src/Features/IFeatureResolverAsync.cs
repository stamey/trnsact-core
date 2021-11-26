using System.Threading.Tasks;

namespace trnsACT.Core.Features
{
    public interface IFeatureResolverAsync<Request, Response>
    {
        Task<Response> ResolveAsync(Request request);
    }

}
