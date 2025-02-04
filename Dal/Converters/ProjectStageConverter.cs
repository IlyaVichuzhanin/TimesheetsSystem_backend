using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class ProjectStageConverter : IConverter<ProjectStageDal, Guid, ProjectStage>
    {
        public ProjectStageDal? Convert(ProjectStage? entity)
        {

            return new ProjectStageDal()
            {
                 Id=entity.Id,
                 Stage = entity.Stage,
                 StageName = entity.StageName,
                 StartDate = entity.StartDate,
                 EndDate = entity.EndDate,
                 Description = entity.Description,
                 Project = new ProjectDal()
                 {
                     Id = entity.Id,
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

        public ProjectStage Convert(ProjectStageDal model)
        {
            return new ProjectStage()
            {
                Id = model.Id,
                Stage = model.Stage,
                StageName = model.StageName,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Description = model.Description,
                Project = new Project()
                {
                    Id = model.Id,
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
