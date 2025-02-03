using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey? Id { get; set; }
    }
    public interface IEntity : IEntity<Guid>
    {

    }
}
