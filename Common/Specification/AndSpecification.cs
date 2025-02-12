using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Specification
{
    internal class AndSpecification<T> : ComposeSpecification<T>
    {
        public AndSpecification(Specification<T> first, Specification<T> second) : base(Expression.AndAlso, first, second)
        {
        }
    }
}
