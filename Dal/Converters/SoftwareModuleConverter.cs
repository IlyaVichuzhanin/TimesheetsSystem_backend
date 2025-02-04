using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class SoftwareModuleConverter : IConverter<SoftwareModuleDal, Guid, SoftwareModule>
    {
        public SoftwareModuleDal? Convert(SoftwareModule? entity)
        {
            return new SoftwareModuleDal()
            {
                Id=entity.Id,
                SoftwareModuleName = entity.SoftwareModuleName,
                Software = new SoftwareDal()
                {
                    Id= entity.SoftwareId,
                    SoftwareName = entity.Software.SoftwareName
                }
            };

        }


        public SoftwareModule Convert(SoftwareModuleDal model)
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
