namespace trnsACT.Core.Interfaces.Requests
{
    public interface IServerCredentialsRequest
    {
        string ClientKey { get; set; }
        string ClientSecret { get; set; }
    }
}
