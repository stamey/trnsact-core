using System.Collections.Generic;

namespace Core.Interfaces.Responses
{
    public interface IApiDataResponse<T> : IApiResponse
    {
        IList<T> Items { get; set; }
        string Key { get; set; }
        string Tag { get; set; }
    }
}
