using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria {get; }
        List<Expression<Func<T, object>>> Includes {get;}
        Expression<Func<T, object>> OrderBy {get;set;}
        Expression<Func<T, object>> OrderByDescending {get;set;}
        int Take {get;}
        int Skip {get;}
        bool IsPagingEnabled {get;}
    }
}