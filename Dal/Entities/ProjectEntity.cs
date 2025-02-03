using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities
{
    public class ProjectEntity : BaseEntity, IProjectEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public double PlanedWorkload { get; set; }
        public double ActualWorkload { get; set; }
        public double PlanedSoftwareHours { get; set; }
        public double ActualSoftwareHours { get; set; }
    }
}
