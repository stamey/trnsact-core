using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Features
{
    public interface IDataService<T>
    {
        Task<T> AddAsync(T t);

        Task<bool> DeleteAsync(int id);

        Task<IEnumerable<T>> FindAsync(T t);

        Task<T> FindByIdAsync(int id);

        Task<T> FindByReferenceAsync(string name, int companyId);

        Task<T> UpdateAsync(T t);
    }
}
