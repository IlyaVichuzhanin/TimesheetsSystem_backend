﻿using System;
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
        public string Description { get; set; }
        public Project Project { get; set; }
        public Guid ProjectId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}
