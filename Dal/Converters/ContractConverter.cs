using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class ContractConverter : IConverter<ContractDto, Guid, Contract>
    {
        public ContractDto? Convert(Contract? entity)
        {
            return new ContractDto()
            {
                Id=entity.Id,
                ContractName = entity.ContractName,
                Company = new CompanyDto()
                {
                    Id=entity.Id, 
                    CompanyName = entity.Company.CompanyName
                }

            };
        }

        public Contract Convert(ContractDto model)
        {

            return new Contract()
            {
                Id=model.Id,
                ContractName = model.ContractName,
                ContractNumber = model.ContractNumber,
                CompanyId = model.Company.Id,
                Company = new Company()
                {
                    Id=model.Company.Id,
                    CompanyName = model.Company.CompanyName,
                }
                
            };

        }
    }
}
