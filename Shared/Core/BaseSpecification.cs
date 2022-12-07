namespace Build.Shared.Core;

using Build.Shared.Core.Interfaces;

public abstract class BaseSpecification<T> : ISpecification<T>
{
    protected abstract IQuery<T> ConfigQuery (IQuery<T> query);

    public IQuery<T> Apply (IQuery<T> query)
    {
        return ConfigQuery(query);
    }
}