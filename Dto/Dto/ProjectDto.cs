using Dto.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Business;

namespace Dto.Dto
{
    public class ProjectDto : BaseDto
    {
        public string ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public ContractDto Contract { get; set; }
    }
}
