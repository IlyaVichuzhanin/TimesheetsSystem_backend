using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Business.Employee
{
    public class EmployeeDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string PersonelNumber { get; set; }
        public string CompanyName { get; set; }
    }
}
