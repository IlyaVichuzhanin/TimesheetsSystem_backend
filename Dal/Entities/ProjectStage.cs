using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities
{
    public class ProjectStage : BaseEntity
    {
    public int Stage { get; set; }
    public string StageName { get; set; }
    public Project Project { get; set; }
    public Guid ProjectId { get; set; }
    public Contract Contract { get; set; }
    public Guid ContractId { get; set; }
    public Company Company { get; set; }
    public Guid CompanyId { get; set; }
    }
}
