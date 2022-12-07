namespace Build.Domain.Specifications;

using Build.Domain.Interfaces;

public abstract class BaseSpecification<T> : ISpecification<T>
{
    protected abstract IQuery<T> ConfigQuery (IQuery<T> query);

    public IQuery<T> Apply (IQuery<T> query)
    {
        return ConfigQuery(query);
    }
}