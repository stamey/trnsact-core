using System.Threading.Tasks;

namespace trnsACT.Core.Company
{
    public interface ICompanyService<T>
    {
        Task<T> AddAsync(T t);

        Task<T> FindAsync(string name);

        Task<T> FindIdAsync(int id);

        Task<bool> IsCompanyValid(int companyID, string securityKey, string securitySecret);

        Task<T> UpdateAsync(T t);
    }
}