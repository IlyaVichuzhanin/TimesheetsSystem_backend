using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Specification
{
    public class ExpressionSpecification<T> : Specification<T>
    {
        private readonly Expression<Func<T, bool>> _predicate;

        public ExpressionSpecification(Expression<Func<T, bool>> predicate)
        {
            _predicate = predicate;
        }

        protected override Expression<Func<T, bool>> ToExpression() => _predicate;
    }
}
