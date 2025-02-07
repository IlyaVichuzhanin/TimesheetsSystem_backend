using Dto.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;

namespace Dal.Converters
{
    public interface IConverter<TDal, TPrimaryKey, TEntity>
        where TDal : IDal
        where TEntity : IEntity<TPrimaryKey>
    {
        TDal? Convert(TEntity? entity);
        TEntity Convert(TDal model);
    }
}
