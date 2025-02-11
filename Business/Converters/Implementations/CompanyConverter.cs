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
        public CompanyDto? Convert(CompanyDal? dal)
        {
            return new CompanyDto()
            {
                Id = dal.Id,
                CompanyName = dal.CompanyName
            };
        }

        public CompanyDal Convert(CompanyDto dto)
        {
            return new CompanyDal()
            {
                Id = dto.Id,
                CompanyName = dto.CompanyName
            };
        }
    }
}
