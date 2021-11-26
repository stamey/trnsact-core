using System.Threading.Tasks;

namespace Core.Features
{
    public interface IFeatureResolverAsync<Request, Response>
    {
        Task<Response> ResolveAsync(Request request);
    }

}
