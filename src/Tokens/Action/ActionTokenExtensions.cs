using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using trnsACT.Core.Security;

namespace trnsACT.Core.Tokens
{
    public static class ActionTokenExtensions
    {
        public static string CreateActionToken(this IActionToken token, ITokenSettings settings)
        {
            return CreateActionTokenFromValues(
                                                token.Name,
                                                token.CompanyId,
                                                token.SecurityStamp,
                                                settings.Issuer,
                                                settings.Secret,
                                                token.ExpirationInMinutes,
                                                token.Action,
                                                token.Reference
                                              );
        }

        private static string CreateActionTokenFromValues(string Name,
                                                          int CompanyId,
                                                          string SecurityStamp,
                                                          string Issuer,
                                                          string Secret,
                                                          int ExpirationInMinutes,
                                                          string Action,
                                                          string Reference = "true")
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Iat,  DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString(), ClaimValueTypes.DateTime),
                new Claim(JwtRegisteredClaimNames.Sub, Name, ClaimValueTypes.String),
                new Claim(JwtCustomClaimTypes.SecurityStamp, SecurityStamp, ClaimValueTypes.String),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString(), ClaimValueTypes.String),
                new Claim(JwtCustomClaimTypes.Reference, Reference, ClaimValueTypes.String),
                new Claim(JwtCustomClaimTypes.Action, Action, ClaimValueTypes.String)
            };
            var claimArray = claims.ToArray();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var jwtToken = new JwtSecurityToken(
                                                Issuer,
                                                CompanyId.ToString(),
                                                claimArray,
                                                notBefore: DateTime.Now,
                                                expires: DateTime.Now.AddMinutes(ExpirationInMinutes),
                                                signingCredentials: credentials
                                                );
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }

        public static ActionTokenValidationResult ValidateActionToken(this string token,
                                                                      ITokenSettings settings)
        {
            ActionTokenValidationResult result = new ActionTokenValidationResult();
            result.IsValid = false;
            result.Token = new ActionToken();
            var jwtHandler = new JwtSecurityTokenHandler();
            if (jwtHandler.CanReadToken(token))
            {
                result.IsReadable = true;
                //Read token and populate result object
                //Token validated, so populate result object
                JwtSecurityToken jsonToken = jwtHandler.ReadJwtToken(token);
                var jwtClaims = jsonToken.Claims;
                foreach (Claim claim in jwtClaims)
                {
                    switch (claim.Type)
                    {
                        case JwtRegisteredClaimNames.Sub:
                            result.Token.Name = claim.Value;
                            break;
                        case JwtCustomClaimTypes.SecurityStamp:
                            result.Token.SecurityStamp = claim.Value;
                            break;
                        case JwtCustomClaimTypes.Reference:
                            result.Token.Reference = claim.Value;
                            break;
                        case JwtCustomClaimTypes.Action:
                            result.Token.Action = claim.Value;
                            break;
                        case JwtRegisteredClaimNames.Aud:
                            result.Token.CompanyId = int.Parse(claim.Value);
                            break;
                        case JwtCustomClaimTypes.Referrer:
                            result.Token.Referrer = claim.Value;
                            break;
                    }
                }
                TokenValidationResult validation = token.Evaluate(settings.Secret, result.Token.CompanyId.ToString());
                if (validation.IsValid)
                {
                    result.IsValid = true;
                }
                else
                {
                    //Error validating token credentials
                    result.IsValid = false;
                    result.Message = validation.Message;
                }
            }
            else
            {
                //Error reading token
                result.IsReadable = false;
                result.IsValid = false;
                result.Message = "Error reading token.";
            }
            return result;
        }
    }
}
