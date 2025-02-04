using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Business.SoftwareModule;
using Dto.Dto;

namespace Business.Service.Task
{
    public interface IProjectTaskService : IBaseService<ProjectTaskDto>
    {
        Task<IReadOnlyCollection<ProjectTaskDto>> ListAsync();
        Task<ProjectTaskDto> CreateOrUpdateAsync(ProjectTaskDto locationDto);
        void Delete(Guid id);
        Task<ProjectTaskDto> GetAsync(Guid id);
    }
}
