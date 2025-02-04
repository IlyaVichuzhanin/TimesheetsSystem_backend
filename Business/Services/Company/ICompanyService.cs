using Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service.Company
{
    public interface ICompanyService : IBaseService<CompanyDto>
    {
        Task<IReadOnlyCollection<CompanyDto>> ListAsync();
        Task<CompanyDto> CreateOrUpdateAsync(CompanyDto locationDto);
        void Delete(Guid id);
        Task<CompanyDto> GetAsync(Guid id);
    }
}
