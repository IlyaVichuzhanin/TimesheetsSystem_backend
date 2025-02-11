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
    public class ProjectStageConverter : IProjectStageConverter
    {
        public ProjectStageDto? Convert(ProjectStageDal? entity)
        {

            return new ProjectStageDto()
            {
                Id = entity.Id,
                Stage = entity.Stage,
                StageName = entity.StageName,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Description = entity.Description,
                Project = new ProjectDto()
                {
                    Id = entity.Id,
                    ProjectNumber = entity.Project.ProjectNumber,
                    ProjectName = entity.Project.ProjectName,
                    StartDate = entity.Project.StartDate,
                    EndDate = entity.Project.EndDate,
                    Description = entity.Project.Description,
                    Contract = new ContractDto()
                    {
                        Id = entity.Project.Contract.Id,
                        ContractName = entity.Project.Contract.ContractName,
                        ContractNumber = entity.Project.Contract.ContractNumber,
                        StartDate = entity.Project.Contract.StartDate,
                        EndDate = entity.Project.Contract.EndDate,
                        Company = new CompanyDto()
                        {
                            Id = entity.Project.Contract.Company.Id,
                            CompanyName = entity.Project.Contract.Company.CompanyName
                        }
                    }
                }
            };
        }

        public ProjectStageDal Convert(ProjectStageDto model)
        {
            return new ProjectStageDal()
            {
                Id = model.Id,
                Stage = model.Stage,
                StageName = model.StageName,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Description = model.Description,
                Project = new ProjectDal()
                {
                    Id = model.Id,
                    ProjectNumber = model.Project.ProjectNumber,
                    ProjectName = model.Project.ProjectName,
                    StartDate = model.Project.StartDate,
                    EndDate = model.Project.EndDate,
                    Description = model.Project.Description,
                    Contract = new ContractDal()
                    {
                        Id = model.Project.Contract.Id,
                        ContractName = model.Project.Contract.ContractName,
                        ContractNumber = model.Project.Contract.ContractNumber,
                        StartDate = model.Project.Contract.StartDate,
                        EndDate = model.Project.Contract.EndDate,
                        Company = new CompanyDal()
                        {
                            Id = model.Project.Contract.Company.Id,
                            CompanyName = model.Project.Contract.Company.CompanyName
                        }
                    }
                }
            };
        }
    }
}
