namespace trnsACT.Core.Interfaces.Requests
{
    public interface ICredentialsRequest
    {
        string Password { get; set; }
        string Username { get; set; }
    }
}
