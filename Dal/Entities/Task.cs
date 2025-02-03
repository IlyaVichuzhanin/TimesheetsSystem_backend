using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities
{
    public class Task : ProjectEntity
    {
        public int TaskPosition { get; set; }
        public string TaskName { get; set; }
        public Project Project { get; set; }
        public Contract Contract { get; set; }
        public Company Company { get; set; }
        public Employee Executor { get; set; }
    }
}
