using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Business.Service
{
    public interface IBaseService<T>
    {
        Task<IReadOnlyCollection<T>> ListAsync();
        Task<T> CreateOrUpdateAsync(T dto);
        System.Threading.Tasks.Task Delete(Guid id);
        Task<T> GetAsync(Guid id);
    }
}
