namespace trnsACT.Core.Interfaces.Requests
{
    public interface IWebRequest
    {
        string BrowserDescription { get; set; }
        string RemoteAddress { get; set; }
    }
}
