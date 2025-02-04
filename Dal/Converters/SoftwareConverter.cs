using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class SoftwareConverter : IConverter<SoftwareDal, Guid, Software>
    {
        public SoftwareDal? Convert(Software? entity)
        {
            return new SoftwareDal()
            {
                Id=entity.Id,
                SoftwareName = entity.SoftwareName,
            };
        }

        public Software Convert(SoftwareDal model)
        {
            return new Software()
            {
                Id = model.Id,
                SoftwareName = model.SoftwareName,
            };
        }
    }
}
