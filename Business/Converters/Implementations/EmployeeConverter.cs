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
    public class EmployeeConverter : IEmployeeConverter
    {
        public EmployeeDto? Convert(EmployeeDal? dal)
        {
            return new EmployeeDto()
            {
                Id = dal.Id,
                FirstName = dal.FirstName,
                LastName = dal.LastName,
                Patronymic = dal.Patronymic,
                PersonelNumber = dal.PersonelNumber,
                Company = new CompanyDto()
                {
                    Id = dal.Company.Id,
                    CompanyName = dal.Company.CompanyName
                }

            };
        }

        public EmployeeDal Convert(EmployeeDto dto)
        {
            return new EmployeeDal()
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Patronymic = dto.Patronymic,
                PersonelNumber = dto.PersonelNumber,
                Company = new CompanyDal()
                {
                    Id = dto.Company.Id,
                    CompanyName = dto.Company.CompanyName
                }
            };
        }
    }
}
