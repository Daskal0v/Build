namespace Build.Domain.Interfaces;
public interface ISpecification<T>
{
    /// <summary>
    /// Applies the query defined within the specification to the given objects.
    /// </summary>
    /// <returns></returns>
    IQuery<T> Apply (IQuery<T> query);
}
