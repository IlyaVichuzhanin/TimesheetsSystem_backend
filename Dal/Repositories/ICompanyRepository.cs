using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Repositories
{
    public interface ICompanyRepository : IRepository<CompanyDto, Guid>
    {
    }
}
