using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Specification
{
    internal class NotSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _specification;

        public NotSpecification(Specification<T> specification)
        {
            _specification = specification;
        }

        protected override Expression<Func<T, bool>> ToExpression()
        {
            var negateExpression = (Expression)Expression.Not(_specification.Predicate.Body);

            return Expression.Lambda<Func<T, bool>>(negateExpression, _specification.Predicate.Parameters[0]);
        }
    }
}
