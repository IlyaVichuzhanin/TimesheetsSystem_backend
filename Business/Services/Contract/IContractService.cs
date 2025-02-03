using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Business.Company;
using Dto.Business.Contract;

namespace Business.Service.Contract
{
    public interface IContractService : IBaseService<ContractDto>
    {
        Task<IReadOnlyCollection<ContractDto>> ListAsync();
        Task<ContractDto> CreateOrUpdateAsync(ContractDto locationDto);
        void Delete(Guid id);
        Task<ContractDto> GetAsync(Guid id);
    }
}
