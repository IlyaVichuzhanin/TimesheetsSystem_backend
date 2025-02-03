using Dto.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;

namespace Dal.Converters
{
    public interface IConverter<TModel, TPrimaryKey, TEntity>
        where TModel : IDto
        where TEntity : IEntity<TPrimaryKey>
    {
        TModel? Convert(TEntity? entity);
        TEntity Convert(TModel model);
    }
}
