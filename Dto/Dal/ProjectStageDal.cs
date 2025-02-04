using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dal
{
    public class ProjectStageDal : BaseDal
    {
        public int Stage { get; set; }
        public string StageName { get; set; }
        public string Description { get; set; }
        public ProjectDal Project { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
