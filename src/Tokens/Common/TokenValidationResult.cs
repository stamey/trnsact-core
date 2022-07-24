namespace trnsACT.Core.Tokens
{
    public class TokenValidationResult : ITokenValidationResult
    {
        public bool IsExpired { get; set; }
        public bool IsReadable { get; set; }
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public int ResultCode { get; set; }
    }
}