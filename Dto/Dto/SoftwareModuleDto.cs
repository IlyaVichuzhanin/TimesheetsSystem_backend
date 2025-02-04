using Dto.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dto
{
    public class SoftwareModuleDto : BaseDto
    {
        public string SoftwareModuleName { get; set; }
        public SoftwareDto Software { get; set; }
    }
}
