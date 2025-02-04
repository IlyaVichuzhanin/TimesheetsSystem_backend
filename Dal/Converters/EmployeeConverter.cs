using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class EmployeeConverter : IConverter<EmployeeDal, Guid, Employee>
    {
        public EmployeeDal? Convert(Employee? entity)
        {
            return new EmployeeDal()
            {
               Id=entity.Id,
               FirstName=entity.FirstName,
               LastName=entity.LastName,
               Patronymic = entity.Patronymic,
               PersonelNumber = entity.PersonelNumber,
               Company = new CompanyDal()
               {
                   Id=entity.CompanyId,
                   CompanyName = entity.Company.CompanyName
               }

            };
        }

        public Employee Convert(EmployeeDal model)
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
