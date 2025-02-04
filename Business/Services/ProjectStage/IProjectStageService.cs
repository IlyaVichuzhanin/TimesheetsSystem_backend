using Dto.Business.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Dto;

namespace Business.Service.ProjectStage
{
    public interface IProjectStageService : IBaseService<ProjectStageDto>
    {
        Task<IReadOnlyCollection<ProjectStageDto>> ListAsync();
        Task<ProjectStageDto> CreateOrUpdateAsync(ProjectStageDto locationDto);
        void Delete(Guid id);
        Task<ProjectStageDto> GetAsync(Guid id);
    }
}
