using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class ProjectConverter : IConverter<ProjectDal, Guid, Project>
    {
        public ProjectDal? Convert(Project? entity)
        {

            return new ProjectDal()
            {
                Id=entity.Id,
                ProjectNumber = entity.ProjectNumber,
                ProjectName = entity.ProjectName,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Description = entity.Description,
                Contract = new ContractDal()
                {
                    Id= entity.ContractId,
                    ContractName = entity.Contract.ContractName,
                    ContractNumber = entity.Contract.ContractNumber,
                    StartDate = entity.Contract.StartDate,
                    EndDate = entity.Contract.EndDate,
                    Company = new CompanyDal()
                    {
                        Id = entity.Contract.CompanyId,
                        CompanyName = entity.Contract.Company.CompanyName
                    }
                }
            };
        }

        public Project Convert(ProjectDal model)
        {
            return new Project()
            {
                Id = model.Id,
                ProjectNumber = model.ProjectNumber,
                ProjectName = model.ProjectName,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Description = model.Description,
                Contract = new Contract()
                {
                    Id = model.Contract.Id,
                    ContractName = model.Contract.ContractName,
                    ContractNumber = model.Contract.ContractNumber,
                    StartDate = model.Contract.StartDate,
                    EndDate = model.Contract.EndDate,
                    Company = new Company()
                    {
                        Id = model.Contract.Company.Id,
                        CompanyName = model.Contract.Company.CompanyName
                    }
                }
            };
        }
    }
}
