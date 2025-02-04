using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Business
{
    public class BaseDto<TPrimaryKey>
    {
        public TPrimaryKey? Id { get; set; }
    }

    public class BaseDto : BaseDto<Guid>
    {
    }
}
