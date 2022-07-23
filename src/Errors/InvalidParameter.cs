namespace trnsACT.Core.Errors
{
    public class Error : IError
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}
