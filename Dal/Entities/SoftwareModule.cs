using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities
{
    public class SoftwareModule : BaseEntity
    {
        public string SoftwareModuleName { get; set; }
        public Software Software { get; set; }
        public Guid SoftwareId { get; set; }
    }
}
