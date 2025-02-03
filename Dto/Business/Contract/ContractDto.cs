using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Business.Contract
{
    public class ContractDto : BaseDto
    {
        public string ContractNumber { get; set; }
        public string ContractName { get; set; }
        public string CompanyName { get; set; }
    }
}
