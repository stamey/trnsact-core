using trnsACT.Core.Features;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace trnsACT.Core.Email
{
    public interface IEmailsService<T>: IFeatureService<T>
    {
        Task<IList<T>> FindAllAsync(int companyId);
        Task<IList<T>> FindSomeAsync(EmailFilter filter);
    }
}
