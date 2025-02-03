using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dal
{
    public interface IDto<TPrimaryKey>
    {
        TPrimaryKey? Id { get; set; }
    }

    public interface IDto : IDto<Guid>
    {
    }
}
