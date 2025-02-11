using Dal.Entities;
using Dto.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Dto;

namespace Business.Converters.Implementations
{
    public class SoftwareModuleConverter : ISoftwareModuleConverter
    {
        public SoftwareModuleDto? Convert(SoftwareModuleDal? entity)
        {
            return new SoftwareModuleDto()
            {
                Id = entity.Id,
                SoftwareModuleName = entity.SoftwareModuleName,
                Software = new SoftwareDto()
                {
                    Id = entity.Software.Id,
                    SoftwareName = entity.Software.SoftwareName
                }
            };

        }


        public SoftwareModuleDal Convert(SoftwareModuleDto model)
        {
            return new SoftwareModuleDal()
            {
                Id = model.Id,
                SoftwareModuleName = model.SoftwareModuleName,
                Software = new SoftwareDal()
                {
                    Id = model.Software.Id,
                    SoftwareName = model.Software.SoftwareName
                }

            };
        }
    }
}
