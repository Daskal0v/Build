namespace Build.Domain.Entities;

using Build.Domain.Events;
using Build.Domain.Interfaces;

public abstract class BaseAggregateRoot<T> : BaseEntity<T>, IAggregateRoot
{
    /// <summary>
    /// Gets or sets the list of events for the entity.
    /// </summary>
    public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
}