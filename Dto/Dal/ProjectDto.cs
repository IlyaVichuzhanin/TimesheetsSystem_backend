using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dal
{
    public class ProjectDto : BaseDto
    {
        public string ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public ContractDto Contract { get; set; }
        public CompanyDto Company { get; set; }
    }
}
