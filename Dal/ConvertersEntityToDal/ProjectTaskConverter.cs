using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class ProjectTaskConverter : IConverter<ProjectTaskDal, Guid, ProjectTask>
    {
        public ProjectTaskDal? Convert(ProjectTask? entity)
        {
            return new ProjectTaskDal()
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
                Project = new ProjectDal()
                {
                    Id = entity.ProjectId,
                    ProjectNumber = entity.Project.ProjectNumber,
                    ProjectName = entity.Project.ProjectName,
                    StartDate = entity.Project.StartDate,
                    EndDate = entity.Project.EndDate,
                    Description = entity.Project.Description,
                    Contract = new ContractDal()
                    {
                        Id = entity.Project.ContractId,
                        ContractName = entity.Project.Contract.ContractName,
                        ContractNumber = entity.Project.Contract.ContractNumber,
                        StartDate = entity.Project.Contract.StartDate,
                        EndDate = entity.Project.Contract.EndDate,
                        Company = new CompanyDal()
                        {
                            Id = entity.Project.Contract.CompanyId,
                            CompanyName = entity.Project.Contract.Company.CompanyName
                        }
                    }
                }
            };
        }

        public ProjectTask Convert(ProjectTaskDal model)
        {
            return new ProjectTask()
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
                Project = new Project()
                {
                    Id = model.Project.Id,
                    ProjectNumber = model.Project.ProjectNumber,
                    ProjectName = model.Project.ProjectName,
                    StartDate = model.Project.StartDate,
                    EndDate = model.Project.EndDate,
                    Description = model.Project.Description,
                    Contract = new Contract()
                    {
                        Id = model.Project.Contract.Id,
                        ContractName = model.Project.Contract.ContractName,
                        ContractNumber = model.Project.Contract.ContractNumber,
                        StartDate = model.Project.Contract.StartDate,
                        EndDate = model.Project.Contract.EndDate,
                        Company = new Company()
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
