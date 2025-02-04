using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Business.Employee;
using Dto.Dto;

namespace Business.Service.Project
{
    public interface IProjectService : IBaseService<ProjectDto>
    {
        Task<IReadOnlyCollection<ProjectDto>> ListAsync();
        Task<ProjectDto> CreateOrUpdateAsync(ProjectDto locationDto);
        void Delete(Guid id);
        Task<ProjectDto> GetAsync(Guid id);

    }
}
