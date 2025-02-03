using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dal
{
    public class ProjectStageDto : BaseDto
    {
        public int Stage { get; set; }
        public string StageName { get; set; }
        public ProjectDto Project { get; set; }
        public ContractDto Contract { get; set; }
        public CompanyDto Company { get; set; }


    }
}
