﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Business;

namespace Dto.Dto
{
    public class ProjectStageDto : BaseDto
    {
        public int Stage { get; set; }
        public string StageName { get; set; }
        public string Description { get; set; }
        public ProjectDto Project { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
