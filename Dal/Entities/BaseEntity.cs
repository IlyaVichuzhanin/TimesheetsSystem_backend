using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities
{
    public class BaseEntity : IEntity<Guid>
    {
        public Guid Id { get; set; }

    }
}
