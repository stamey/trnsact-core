namespace trnsACT.Core.Interfaces.Requests
{
    public interface IApiRequest: ILocaleRequest
    {
        int CompanyId { get; set; }
    }
}
