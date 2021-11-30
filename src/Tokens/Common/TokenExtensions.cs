using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace trnsACT.Core.Tokens
{
    public static class TokenExtensions
    {
        private const string DEFAULT_TOKEN_ITEM_VALUE = "none";
        /// <summary>
        /// Validates the elements of the token
        /// </summary>
        /// <param name="token">The token to be evaluated.</param>
        /// <param name="secret">The expected token secret.</param>
        /// <param name="audience">The expected token audience.</param>
        /// <returns></returns>
        public static TokenValidationResult Evaluate(this string token,
                                                     string secret,
                                                     string audience)
        {
            TokenValidationResult result = new TokenValidationResult();
            result.IsValid = false;
            // Create token validation parameters for the signed JWT
            // This object will be used to verify the cryptographic signature of the received JWT
            byte[] encodedSecret = Encoding.ASCII.GetBytes(secret);
            TokenValidationParameters validationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(encodedSecret),
                ValidateIssuer = false,
                ValidateAudience = true,
                ValidAudience = audience
            };
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            Microsoft.IdentityModel.Tokens.SecurityToken validated;
            try
            {
                handler.ValidateToken(token, validationParameters, out validated);
                result.IsValid = true;
            }
            catch (SecurityTokenDecryptionFailedException e)
            {
                result.Message = e.Message;
                result.Message = "Token could not be decrypted.";
                result.IsValid = false;
            }
            catch (SecurityTokenExpiredException e)
            {
                result.Message = e.Message;
                result.Message = "Token has expired.";
                result.IsValid = false;
            }
            catch (SecurityTokenInvalidAudienceException e)
            {
                result.Message = e.Message;
                result.Message = "Token could not be decrypted.";
                result.IsValid = false;
            }
            catch (SecurityTokenInvalidLifetimeException e)
            {
                result.Message = e.Message;
                result.Message = "Token has expired.";
                result.IsValid = false;
            }
            catch (SecurityTokenNotYetValidException e)
            {
                result.Message = e.Message;
                result.Message = "Token has expired.";
                result.IsValid = false;
            }
            catch (Exception e)
            {
                result.Message = e.Message;
                result.IsValid = false;
            }
            return result;
        }
    }
}
