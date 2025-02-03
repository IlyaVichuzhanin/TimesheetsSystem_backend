using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities
{
    public class Project
    {
        public string ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public Contract Contract { get; set; }
        public Guid ContractId { get; set; }
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }
    }
}
