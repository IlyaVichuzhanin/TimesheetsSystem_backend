using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class EmployeeConverter : IConverter<EmployeeDto, Guid, Employee>
    {
        public EmployeeDto? Convert(Employee? entity)
        {
            return new EmployeeDto()
            {
               Id=entity.Id,
               FirstName=entity.FirstName,
               LastName=entity.LastName,
               Patronymic = entity.Patronymic,
               PersonelNumber = entity.PersonelNumber,
               Company = new CompanyDto()
               {
                   Id=entity.CompanyId,
                   CompanyName = entity.Company.CompanyName
               }

            };
        }

        public Employee Convert(EmployeeDto model)
        {
            return new Employee()
            {
                Id=model.Id,
                FirstName=model.FirstName,
                LastName=model.LastName,
                Patronymic = model.Patronymic,
                PersonelNumber = model.PersonelNumber,
                CompanyId = model.Company.Id,
                Company = new Company()
                {
                    Id=model.Company.Id, 
                    CompanyName = model.Company.CompanyName
                }
            };
        }
    }
}
