namespace Core.Errors
{
    public interface IInvalidParameter
    {
        string Message { get; set; }
        string Name { get; set; }
    }
}