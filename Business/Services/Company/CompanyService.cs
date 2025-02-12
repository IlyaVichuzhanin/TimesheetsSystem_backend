using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Converters;
using Business.Service;
using Business.Service.Company;
using Dal.Repositories;
using Dto.Dto;

namespace Business.Services.Company
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly ICompanyConverter _companyConverter;

        public CompanyService(ICompanyRepository companyRepository, ICompanyConverter companyConverter)
        {
            _companyRepository = companyRepository;
            _companyConverter = companyConverter;
        }

        public async Task<CompanyDto> CreateOrUpdateAsync(CompanyDto companyDto)
        {
            var result = await  _companyRepository.AddOrUpdateAsync(_companyConverter.Convert(companyDto));
            companyDto.Id = result.Id;
            companyDto.CompanyName = result.CompanyName;
            return companyDto;
        }

        public Task Delete(Guid id)
        {
             return _companyRepository.Delete(id);
        }

        public async Task<CompanyDto> GetAsync(Guid id)
        {
            var company = await _companyRepository.GetByIdAsync(id);
            return _companyConverter.Convert(company);
        }

        public async Task<IReadOnlyCollection<CompanyDto>> ListAsync()
        {
            var result = await _companyRepository.GetAllAsync();
            return result.Select(x => new CompanyDto()
            {
                Id = x.Id,
                CompanyName = x.CompanyName,

            }).ToArray();
        }
    }
}
