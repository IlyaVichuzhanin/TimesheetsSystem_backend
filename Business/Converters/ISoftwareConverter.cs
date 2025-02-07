using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;
using Dto.Dto;

namespace Business.Converters
{
    public interface ISoftwareConverter
    {
        SoftwareDal Convert(SoftwareDto software);
        SoftwareDto Convert(SoftwareDal software);
    }
}
