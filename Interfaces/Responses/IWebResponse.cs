namespace Core.Interfaces.Responses
{
    public interface IWebResponse : IApiResponse,
                                   ITokenResponse
    {
        string NavigateUrl { get; set; }
    }
}
