using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dal
{
    public class ContractDal : BaseDal
    {
        public string ContractNumber { get; set; }
        public string ContractName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public CompanyDal Company { get; set; }
    }
}
