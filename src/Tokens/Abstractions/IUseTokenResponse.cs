using trnsACT.Core.Interfaces.Responses;

namespace trnsACT.Core.Tokens
{
    public interface IUseTokenResponse: IWebResponse, 
                                        IUserResponse, 
                                        IRefreshTokenResponse
    {

    }
}