using trnsACT.Core.UserRoles;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using trnsACT.Core.Security;

namespace trnsACT.Core.Tokens
{
    public static class SecurityTokenExtensions
    {
        public static SecurityTokenValidationResult ValidateSecurityToken(this string token, ITokenSettings settings)
        {
            SecurityTokenValidationResult result = new SecurityTokenValidationResult();
            result.IsValid = false;
            result.Token = new SecurityToken();
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
                        case JwtRegisteredClaimNames.Aud:
                            result.Token.CompanyId = int.Parse(claim.Value);
                            break;
                        case JwtCustomClaimTypes.Referrer:
                            result.Token.Referrer = claim.Value;
                            result.Token.Claims.Add(claim);
                            break;
                        case ClaimTypes.Role:
                            switch (claim.Value)
                            {
                                case SecondaryRoles.HasAnnouncement:
                                case SecondaryRoles.ImpersonationAllowed:
                                case SecondaryRoles.IncompleteProfile:
                                case SecondaryRoles.NotAgreed:
                                case SecondaryRoles.PasswordExpired:
                                case SecondaryRoles.TemporaryPassword:
                                    //Do not add secondary roles to claims list
                                    break;
                                default:
                                    //Add all the other roles:
                                    result.Token.Claims.Add(claim);
                                    break;
                            }
                            break;
                        case JwtRegisteredClaimNames.Iat:
                        case JwtRegisteredClaimNames.Jti:
                        case JwtCustomClaimTypes.Role:
                        case JwtRegisteredClaimNames.Email:
                            // Do not add to claims list
                            break;
                        default:
                            result.Token.Claims.Add(claim);
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
