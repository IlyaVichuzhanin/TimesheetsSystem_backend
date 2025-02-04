using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dal
{
    public interface IDal<TPrimaryKey>
    {
        TPrimaryKey? Id { get; set; }
    }

    public interface IDal : IDal<Guid>
    {
    }
}
