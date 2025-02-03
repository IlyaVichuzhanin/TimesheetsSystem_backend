using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Business.ProjectStage
{
    public class ProjectStageDto 
    {
        public int Stage { get; set; }
        public string StageName { get; set; }
        public string ProjectName { get; set; }
        public string ContractName { get; set; }
        public string CompanyName { get; set; }
    }
}
