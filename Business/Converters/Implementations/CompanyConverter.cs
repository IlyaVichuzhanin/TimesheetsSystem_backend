using Dal.Entities;
using Dto.Dal;
using Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Converters.Implementations
{
    public class CompanyConverter : ICompanyConverter
    {
        public CompanyDto? Convert(CompanyDal? entity)
        {
            return new CompanyDto()
            {
                Id = entity.Id,
                CompanyName = entity.CompanyName
            };
        }

        public CompanyDal Convert(CompanyDto model)
        {
            return new CompanyDal()
            {
                Id = model.Id,
                CompanyName = model.CompanyName
            };
        }
    }
}
