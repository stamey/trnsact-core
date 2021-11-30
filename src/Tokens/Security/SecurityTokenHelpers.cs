using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using trnsACT.Core.Security;

namespace trnsACT.Core.Tokens
{
    public static class SecurityTokenHelpers
    {
        public static string CreateSecurityToken(ISecurityToken token, TokenSettings settings) 
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Iat,  DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString(), ClaimValueTypes.DateTime),
                new Claim(JwtRegisteredClaimNames.Sub, token.Name),
                new Claim(JwtCustomClaimTypes.Role, token.Role),
                new Claim(JwtRegisteredClaimNames.Email, token.EmailAddress),
                new Claim(JwtCustomClaimTypes.SecurityStamp, token.SecurityStamp),
                new Claim(JwtRegisteredClaimNames.Jti, SecurityHelpers.CreateSecurityStamp())
            };
            claims.AddRange(token.Claims);
            var claimArray = claims.ToArray();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.Secret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var jwtToken = new JwtSecurityToken(
                                                settings.Issuer,
                                                token.CompanyId.ToString(),
                                                claimArray,
                                                notBefore: DateTime.Now,
                                                expires: DateTime.Now.AddMinutes(settings.AccessExpiration),
                                                signingCredentials: credentials
                                                );
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
    }

}
