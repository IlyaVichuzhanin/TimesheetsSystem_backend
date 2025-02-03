using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Business.Task
{
    public class ProjectTaskDto
    {
        public int TaskPosition { get; set; }
        public string TaskName { get; set; }
        public string ProjectName { get; set; }
        public string ContractName { get; set; }
        public string CompanyName { get; set; }
        public string ExecutorName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public double PlanedWorkload { get; set; }
        public double ActualWorkload { get; set; }
        public double PlanedSoftwareHours { get; set; }
        public double ActualSoftwareHours { get; set; }
    }
}
