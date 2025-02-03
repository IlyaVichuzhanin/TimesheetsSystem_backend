using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dal
{
    public class BaseDto : IDto
    {
        public Guid Id { get; set; }
    }
}
