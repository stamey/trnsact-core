using System.Collections.Generic;
using System.Security.Claims;

namespace trnsACT.Core.Tokens
{
    public class SecurityToken : ISecurityToken
    {
        public SecurityToken()
        {
            Claims = new List<Claim>();
        }
        public IList<Claim> Claims { get; set; }
        public int CompanyId { get; set; }
        public string EmailAddress { get; set; }
        public int ExpirationInMinutes { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string SecurityStamp { get; set; }
        public string Referer { get; set; }
    }
}