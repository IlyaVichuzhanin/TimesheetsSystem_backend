using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;
using Dto.Dto;

namespace Business.Converters
{
    public interface IProjectTaskConverter
    {
        ProjectTaskDal Convert(ProjectTaskDto projectTask);
        ProjectTaskDto Convert(ProjectTaskDal projectTask);
    }
}
