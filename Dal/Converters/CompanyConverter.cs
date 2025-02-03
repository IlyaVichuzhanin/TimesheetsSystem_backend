using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class CompanyConverter : IConverter<CompanyDto, Guid, Company>
    {
        public CompanyDto? Convert(Company? entity) => entity is not null? new CompanyDto()
        {
            Id=entity.Id,
            CompanyName = entity.CompanyName
        } : null;

        public Company Convert(CompanyDto model)
            => new()
            {
                Id = model.Id,
                CompanyName = model.CompanyName,
            };
    }
}
