using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class ProjectConverter : IConverter<ProjectDto, Guid, Project>
    {
        public ProjectDto? Convert(Project? entity)
        {
            var companyDto = new CompanyDto()
            {
                Id = entity.Contract.CompanyId,
                CompanyName = entity.Contract.Company.CompanyName
            };

            return new ProjectDto()
            {
                Id=entity.Id,
                ProjectNumber = entity.ProjectNumber,
                ProjectName = entity.ProjectName,
                Contract = new ContractDto()
                {
                    Id= entity.ContractId,
                    ContractName = entity.Contract.ContractName,
                    ContractNumber = entity.Contract.ContractNumber,
                    Company = companyDto
                },
                Company = companyDto

            };
        }

        public Project Convert(ProjectDto model)
        {
            var company = new Company()
            {
                Id = model.Contract.Company.Id,
                CompanyName = model.Contract.Company.CompanyName,
            };
            return new Project()
            {
                Id = model.Id,
                ProjectNumber = model.ProjectNumber,
                ProjectName = model.ProjectName,
                ContractId = model.Contract.Id,
                Contract = new Contract()
                {
                    Id = model.Contract.Id,
                    ContractName = model.Contract.ContractName,
                    ContractNumber = model.Contract.ContractNumber,
                    Company = company

                },
                CompanyId = model.Company.Id,
                Company = company
            };
        }
    }
}
