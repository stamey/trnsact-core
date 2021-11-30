namespace trnsACT.Core.Tokens
{
    public interface ITokenValidationResult
    {
        bool IsReadable { get; set; }
        bool IsValid { get; set; }
        string Message { get; set; }
        int ResultCode { get; set; }
    }
}