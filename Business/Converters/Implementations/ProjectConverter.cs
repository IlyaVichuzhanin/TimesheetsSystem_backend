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
    public class ProjectConverter : IProjectConverter
    {
        public ProjectDto? Convert(ProjectDal? dal)
        {

            return new ProjectDto()
            {
                Id = dal.Id,
                ProjectNumber = dal.ProjectNumber,
                ProjectName = dal.ProjectName,
                StartDate = dal.StartDate,
                EndDate = dal.EndDate,
                Description = dal.Description,
                Contract = new ContractDto()
                {
                    Id = dal.Contract.Id,
                    ContractName = dal.Contract.ContractName,
                    ContractNumber = dal.Contract.ContractNumber,
                    StartDate = dal.Contract.StartDate,
                    EndDate = dal.Contract.EndDate,
                    Company = new CompanyDto()
                    {
                        Id = dal.Contract.Company.Id,
                        CompanyName = dal.Contract.Company.CompanyName
                    }
                }
            };
        }

        public ProjectDal Convert(ProjectDto dto)
        {
            return new ProjectDal()
            {
                Id = dto.Id,
                ProjectNumber = dto.ProjectNumber,
                ProjectName = dto.ProjectName,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                Description = dto.Description,
                Contract = new ContractDal()
                {
                    Id = dto.Contract.Id,
                    ContractName = dto.Contract.ContractName,
                    ContractNumber = dto.Contract.ContractNumber,
                    StartDate = dto.Contract.StartDate,
                    EndDate = dto.Contract.EndDate,
                    Company = new CompanyDal()
                    {
                        Id = dto.Contract.Company.Id,
                        CompanyName = dto.Contract.Company.CompanyName
                    }
                }
            };
        }
    }
}
