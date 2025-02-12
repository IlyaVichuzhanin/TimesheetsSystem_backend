using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Specification
{
    internal class OrSpecification<T> : ComposeSpecification<T>
    {
        public OrSpecification(Specification<T> first, Specification<T> second) : base(Expression.OrElse, first, second)
        {
        }
    }
}
