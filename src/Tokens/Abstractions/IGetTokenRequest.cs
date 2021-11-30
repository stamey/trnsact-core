using trnsACT.Core.Interfaces.Requests;

namespace trnsACT.Core.Tokens
{
    public interface IGetTokenRequest : IActionRequest
    {
        string EmailAddress { get; set; }
    }
}