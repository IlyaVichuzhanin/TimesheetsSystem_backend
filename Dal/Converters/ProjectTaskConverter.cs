using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dto.Dal;

namespace Dal.Converters
{
    public class ProjectTaskConverter : IConverter<ProjectTaskDto, Guid, ProjectTask>
    {
        public ProjectTaskDto? Convert(ProjectTask? entity)
        {
            throw new NotImplementedException();
        }

        public ProjectTask Convert(ProjectTaskDto model)
        {
            throw new NotImplementedException();
        }
    }
}
