namespace trnsACT.Core.Tokens
{
    public interface IToken
    {
        int CompanyId { get; set; }
        int ExpirationInMinutes { get; set; }
        string Name { get; set; }
        string SecurityStamp { get; set; }
    }
}