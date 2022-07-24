namespace trnsACT.Core.Tokens
{
    public class SecurityTokenValidationResult : ITokenValidationResult
    {
        public bool IsExpired { get; set; }
        public bool IsReadable { get; set; }
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public int ResultCode { get; set; }
        public ISecurityToken Token { get; set; }
    }
}
