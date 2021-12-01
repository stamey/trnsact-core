namespace trnsACT.Core.Connection
{
    public class ServerConnectionSettings : IServerConnectionSettings
    {
        public string BaseURL { get; set; }
        public string ClientDescription { get; set; }
        public string ClientKey { get; set; }
        public string ClientSecret { get; set; }
        public int CompanyId { get; set; }
        public string Locale { get; set; }
        public string UserExistsPath { get; set; }
    }
}
