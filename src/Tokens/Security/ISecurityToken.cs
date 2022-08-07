using System.Collections.Generic;
using System.Security.Claims;

namespace trnsACT.Core.Tokens
{
    public interface ISecurityToken: IToken
    {
        IList<Claim> Claims { get; set; }
        string EmailAddress { get; set; }
        string Role { get; set; }
        string Referer { get; set; }
    }
}