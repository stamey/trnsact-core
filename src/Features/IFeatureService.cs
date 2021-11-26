using System.Threading.Tasks;

namespace trnsACT.Core.Features
{
    public interface IFeatureService<T>
    {
        Task<T> AddAsync(T t);

        Task<T> FindAsync(string name,
                          int companyId,
                          bool useCache = true);

        Task<T> FindIdAsync(int id,
                            int companyId,
                            bool useCache = true);

        Task<T> FindReferenceAsync(string reference,
                                   int companyId,
                                   bool useCache = true);

        Task<T> UpdateAsync(T t);

    }
}