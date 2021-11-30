using trnsACT.Core.Interfaces.Requests;

namespace trnsACT.Core.Tokens
{
    public interface IUseTokenRequest : IWebRequest, 
                                        ITokenRequest, 
                                        IActionRequest
    {

    }

}