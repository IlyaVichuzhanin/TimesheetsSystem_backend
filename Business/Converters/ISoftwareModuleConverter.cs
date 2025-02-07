using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;
using Dto.Dto;

namespace Business.Converters
{
   public interface ISoftwareModuleConverter
   {
        SoftwareModuleDal Convert(SoftwareModuleDto softwareModule);
       SoftwareModuleDto Convert(SoftwareModuleDal softwareModule);
   }
}
