namespace trnsACT.Core.Tokens
{
    public interface ITokenSettings
    {
        int AccessExpiration { get; set; }
        string Audience { get; set; }
        string Issuer { get; set; }
        int RefreshExpiration { get; set; }
        string Secret { get; set; }
    }
}
