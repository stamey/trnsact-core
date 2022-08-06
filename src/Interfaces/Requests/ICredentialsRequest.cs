namespace trnsACT.Core.Interfaces.Requests
{
    public interface ICredentialsRequest : IIdentityRequest
    {
        string Password { get; set; }
    }
}
