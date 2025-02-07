using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class ContractConverter : IConverter<ContractDal, Guid, Contract>
    {
        public ContractDal? Convert(Contract? entity)
        {
            return new ContractDal()
            {
                Id=entity.Id,
                ContractName = entity.ContractName,
                ContractNumber = entity.ContractNumber,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Description = entity.Description,
                Company = new CompanyDal()
                {
                    Id=entity.CompanyId, 
                    CompanyName = entity.Company.CompanyName
                }

            };
        }

        public Contract Convert(ContractDal model)
        {

            return new Contract()
            {
                Id=model.Id,
                ContractName = model.ContractName,
                ContractNumber = model.ContractNumber,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Description = model.Description,
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
