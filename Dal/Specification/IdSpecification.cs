using Common.Specification;
using Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Specification
{
    public class IdSpecification<TEntity, TPrimaryKey> : ExpressionSpecification<TEntity>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public IdSpecification(TPrimaryKey id) : base(e => Equals(e.Id, id))
        {

        }
    }
}
