namespace Build.Shared.Core;

public abstract class BaseAggregateRoot<T> : BaseEntity<T>
{
    /// <summary>
    /// Gets or sets the list of events for the entity.
    /// </summary>
    public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
}