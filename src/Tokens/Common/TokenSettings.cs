namespace trnsACT.Core.Tokens
{
    public class TokenSettings : ITokenSettings
    {
        public TokenSettings()
        {
            TokenExpiration = new TokenExpiration();
        }
        public string Secret { get; set; }
        
        public string Issuer { get; set; }
        
        public string Audience { get; set; }
        
        public int AccessExpiration { get; set; }
        
        public int RefreshExpiration { get; set; }

        public TokenExpiration TokenExpiration { get; set; }
    }
}