﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dal
{
    public class ProjectTaskDto : BaseDto
    {
        public int TaskPosition { get; set; }
        public string TaskName { get; set; }
        public ProjectDto Project { get; set; }

        public ContractDto Contract { get; set; }

        public CompanyDto Company { get; set; }

        public EmployeeDto Employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public double PlanedWorkload { get; set; }
        public double ActualWorkload { get; set; }
        public double PlanedSoftwareHours { get; set; }
        public double ActualSoftwareHours { get; set; }

    }
}
