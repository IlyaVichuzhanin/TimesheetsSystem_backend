using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class SoftwareConverter : IConverter<SoftwareDto, Guid, Software>
    {
        public SoftwareDto? Convert(Software? entity)
        {
            throw new NotImplementedException();
        }

        public Software Convert(SoftwareDto model)
        {
            throw new NotImplementedException();
        }
    }
}
