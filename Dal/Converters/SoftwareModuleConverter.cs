using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class SoftwareModuleConverter : IConverter<SoftwareModuleDto, Guid, SoftwareModule>
    {
        public SoftwareModuleDto? Convert(SoftwareModule? entity)
        {
            return new SoftwareModuleDto()
            {
                Id=entity.Id,
                SoftwareModuleName = entity.SoftwareModuleName,
                Software = new SoftwareDto() {Id = entity.SoftwareId}
            };

        }


        public SoftwareModule Convert(SoftwareModuleDto model)
        {
            return new SoftwareModule()
            {
                Id=model.Id,
                SoftwareModuleName = model.SoftwareModuleName,
                Software = new Software()
                {
                    Id = model.Software.Id,
                    SoftwareName = model.Software.SoftwareName
                }

            };
        }
    }
}
