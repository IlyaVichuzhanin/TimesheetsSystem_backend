using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class ProjectStageConverter : IConverter<ProjectStageDto, Guid, ProjectStage>
    {
        public ProjectStageDto? Convert(ProjectStage? entity)
        {
            var companyDto = new CompanyDto()
            {
                Id = entity.CompanyId,
                CompanyName = entity.Company.CompanyName
            };

            var contractDto = new ContractDto()
            {
                Id=entity.ContractId,
                ContractName = entity.Contract.ContractName,
                ContractNumber = entity.Contract.ContractNumber,
                Company = companyDto
            };


            return new ProjectStageDto()
            {
                 Id=entity.Id,
                 Stage = entity.Stage,
                 StageName = entity.StageName,
                 Project = new ProjectDto()
                 {
                     Id=entity.ProjectId,
                     ProjectNumber = entity.Project.ProjectNumber,
                     ProjectName = entity.Project.ProjectName,
                     Contract = contractDto,
                     Company = companyDto
                 },
                 Contract = contractDto,
                 Company = companyDto
            };
        }

        public ProjectStage Convert(ProjectStageDto model)
        {
            var company = new Company()
            {
                Id = model.Company.Id,
                CompanyName = model.Company.CompanyName,
            };
            var contract = new Contract()
            {
                Id=model.Contract.Id,
                ContractName = model.Contract.ContractName,
                ContractNumber = model.Contract.ContractNumber,
                Company = company,
                CompanyId = model.Company.Id
            };
             return new ProjectStage()
             {
                 Id=model.Company.Id,
                 Stage = model.Stage,
                 StageName = model.StageName,
                 Project = new Project()
                 {
                     Id=model.Project.Id,
                     ProjectNumber = model.Project.ProjectNumber,
                     ProjectName = model.Project.ProjectName,
                     ContractId=model.Contract.Id,
                     Contract = contract,
                     CompanyId = model.Company.Id,
                     Company = company,

                 },
                 ProjectId = model.Project.Id,
                 Contract = contract,
                 ContractId = contract.Id,
                 Company = company,
                 CompanyId = company.Id
             };
        }
    }
}
