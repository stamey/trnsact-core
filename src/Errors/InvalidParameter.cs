namespace trnsACT.Core.Errors
{
    public class InvalidParameter : IInvalidParameter
    {
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
