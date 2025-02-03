using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Business.ProjectStage;
using Dto.Business.Software;

namespace Business.Service.Software
{
    public interface ISoftwareService : IBaseService<SoftwareDto>
    {
        Task<IReadOnlyCollection<SoftwareDto>> ListAsync();
        Task<SoftwareDto> CreateOrUpdateAsync(SoftwareDto locationDto);
        void Delete(Guid id);
        Task<SoftwareDto> GetAsync(Guid id);
    }
}
