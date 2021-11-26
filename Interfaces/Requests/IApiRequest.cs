namespace Core.Interfaces.Requests
{
    public interface IApiRequest
    {
        int CompanyId { get; set; }
        string Locale { get; set; }
    }
}
