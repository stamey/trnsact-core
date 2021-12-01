namespace trnsACT.Core.Connection
{
    public interface IServerConnectionSettings
    {
        string BaseURL { get; set; }
        string ClientDescription { get; set; }
        string ClientKey { get; set; }
        string ClientSecret { get; set; }
        int CompanyId { get; set; }
        string Locale { get; set; }
        string UserExistsPath { get; set; }
    }
}