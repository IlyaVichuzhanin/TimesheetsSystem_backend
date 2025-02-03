using Dto.Business.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Business.Employee;

namespace Business.Service.Employee
{
    public interface IEmployeeService : IBaseService<EmployeeDto>
    {
        Task<IReadOnlyCollection<EmployeeDto>> ListAsync();
        Task<EmployeeDto> CreateOrUpdateAsync(EmployeeDto locationDto);
        void Delete(Guid id);
        Task<EmployeeDto> GetAsync(Guid id);

    }
}
