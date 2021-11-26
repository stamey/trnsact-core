namespace trnsACT.Core.Interfaces.Responses
{
    public interface IApiResponse
    {
        string Message { get; set; }
        int ResultCode { get; set; }
        bool Success { get; set; }
    }
}
