namespace trnsACT.Core.Tokens
{
    public class ActionToken : IActionToken
    {
        public string Action { get; set; }
        public int CompanyId { get; set; }
        public int ExpirationInMinutes { get; set; }
        public string Locale { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public string Referer { get; set; }
        public string SecurityStamp { get; set; }
    }
}
