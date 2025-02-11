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
    public class ContractConverter : IContractConverter
    {
        public ContractDto? Convert(ContractDal? dal)
        {
            return new ContractDto()
            {
                Id = dal.Id,
                ContractName = dal.ContractName,
                ContractNumber = dal.ContractNumber,
                StartDate = dal.StartDate,
                EndDate = dal.EndDate,
                Description = dal.Description,
                Company = new CompanyDto()
                {
                    Id = dal.Company.Id,
                    CompanyName = dal.Company.CompanyName
                }

            };
        }

        public ContractDal Convert(ContractDto dto)
        {

            return new ContractDal()
            {
                Id = dto.Id,
                ContractName = dto.ContractName,
                ContractNumber = dto.ContractNumber,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                Description = dto.Description,
                Company = new CompanyDal()
                {
                    Id = dto.Company.Id,
                    CompanyName = dto.Company.CompanyName,
                }

            };

        }
    }
}
