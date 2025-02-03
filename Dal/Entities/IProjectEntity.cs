using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities
{
    internal interface IProjectEntity
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        string Description { get; set; }
        double PlanedWorkload { get; set; }
        double ActualWorkload { get; set; }
        double PlanedSoftwareHours { get; set; }
        double ActualSoftwareHours { get; set; }
    }
}
