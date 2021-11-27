namespace trnsACT.Core.Features
{
    public interface IFeatureResolver<Request, Response>
    {
        Response Resolve(Request request);
    }

}
