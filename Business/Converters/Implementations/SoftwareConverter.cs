using Dal.Entities;
using Dto.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Dto;

namespace Business.Converters.Implementations
{
    public class SoftwareConverter : ISoftwareConverter
    {
        public SoftwareDal? Convert(SoftwareDto? entity)
        {
            return new SoftwareDal()
            {
                Id = entity.Id,
                SoftwareName = entity.SoftwareName,
            };
        }

        public SoftwareDto Convert(SoftwareDal model)
        {
            return new SoftwareDto()
            {
                Id = model.Id,
                SoftwareName = model.SoftwareName,
            };
        }
    }
}
