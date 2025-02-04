using Dto.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dto
{
    public class ContractDto : BaseDto
    {
        public string ContractNumber { get; set; }
        public string ContractName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public CompanyDto Company { get; set; }
    }
}
