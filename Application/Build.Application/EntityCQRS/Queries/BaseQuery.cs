namespace Build.Application.EntityCQRS.Queries;

using System.Linq.Expressions;
using Build.Domain.Interfaces;

public class BaseQuery<T> : IQuery<T>
{
    public IQueryable<T> Queryable { get; }

    public BaseQuery (IQueryable<T> queryable)
    {
        Queryable = queryable;
    }

    public IQuery<T> Where (Expression<Func<T, bool>> predicate)
    {
        return new BaseQuery<T>(Queryable.Where(predicate));
    }

    IQuery<T> IQuery<T>.OrderBy<TField> (Expression<Func<T, TField>> keySelector)
    {
        return new BaseQuery<T>(Queryable.OrderBy(keySelector));
    }

    IQuery<T> IQuery<T>.OrderByDescending<TField> (Expression<Func<T, TField>> keySelector)
    {
        return new BaseQuery<T>(Queryable.OrderByDescending(keySelector));
    }

    public IQuery<T> ThenBy<TField> (Expression<Func<T, TField>> keySelector)
    {
        throw new NotImplementedException();
    }

    public IQuery<T> ThenByDescending<TField> (Expression<Func<T, TField>> keySelector)
    {
        throw new NotImplementedException();
    }
}
