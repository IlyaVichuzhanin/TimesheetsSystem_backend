using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class CompanyConverter : IConverter<CompanyDal, Guid, Company>
    {
        public CompanyDal? Convert(Company? entity)
        {
            return new CompanyDal()
            {
                Id=entity.Id,
                CompanyName = entity.CompanyName
            };
        }

        public Company Convert(CompanyDal model)
        {
            return new Company()
            {
                Id = model.Id,
                CompanyName = model.CompanyName
            };
        }
    }
}
