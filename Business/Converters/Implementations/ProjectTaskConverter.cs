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
    public class ProjectTaskConverter : IProjectTaskConverter
    {
        public ProjectTaskDto? Convert(ProjectTaskDal? entity)
        {
            return new ProjectTaskDto()
            {
                Id = entity.Id,
                TaskPosition = entity.TaskPosition,
                TaskName = entity.TaskName,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Description = entity.Description,
                PlanedWorkload = entity.PlanedWorkload,
                ActualWorkload = entity.ActualWorkload,
                PlanedSoftwareHours = entity.PlanedSoftwareHours,
                ActualSoftwareHours = entity.ActualSoftwareHours,
                Project = new ProjectDto()
                {
                    Id = entity.Project.Id,
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

        public ProjectTaskDal Convert(ProjectTaskDto model)
        {
            return new ProjectTaskDal()
            {
                Id = model.Id,
                TaskPosition = model.TaskPosition,
                TaskName = model.TaskName,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Description = model.Description,
                PlanedWorkload = model.PlanedWorkload,
                ActualWorkload = model.ActualWorkload,
                PlanedSoftwareHours = model.PlanedSoftwareHours,
                ActualSoftwareHours = model.ActualSoftwareHours,
                Project = new ProjectDal()
                {
                    Id = model.Project.Id,
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
