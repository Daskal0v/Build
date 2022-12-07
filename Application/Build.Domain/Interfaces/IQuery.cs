namespace Build.Domain.Interfaces;

using System.Linq.Expressions;


public interface IQuery<T>
{
    IQuery<T> Where (Expression<Func<T, bool>> predicate);

    IQuery<T> OrderBy<TField> (Expression<Func<T, TField>> keySelector);

    IQuery<T> OrderByDescending<TField> (Expression<Func<T, TField>> keySelector);

    IQuery<T> ThenBy<TField> (Expression<Func<T, TField>> keySelector);

    IQuery<T> ThenByDescending<TField> (Expression<Func<T, TField>> keySelector);
}
