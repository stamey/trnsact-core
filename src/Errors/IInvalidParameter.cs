namespace trnsACT.Core.Errors
{
    public interface IError
    {
        string Code { get; set; }
        string Message { get; set; }
        string Name { get; set; }
    }
}