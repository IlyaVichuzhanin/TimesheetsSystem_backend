using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dal
{
    public class EmployeeDal : BaseDal
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string PersonelNumber { get; set; }
        public CompanyDal Company { get; set; }
    }
}
