using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Dal;

namespace Dal.Repositories
{
    public interface IContractRepository : IRepository<ContractDal, Guid>
    {
    }
}
