using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Business.Software;
using Dto.Business.SoftwareModule;

namespace Business.Service.SoftwareModule
{
    public interface ISoftwareModuleService : IBaseService<SoftwareModuleDto>
    {
        Task<IReadOnlyCollection<SoftwareModuleDto>> ListAsync();
        Task<SoftwareModuleDto> CreateOrUpdateAsync(SoftwareModuleDto locationDto);
        void Delete(Guid id);
        Task<SoftwareModuleDto> GetAsync(Guid id);
    }
}
