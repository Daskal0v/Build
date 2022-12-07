namespace Build.Domain.Events;

public abstract class BaseDomainEvent
{
    public DateTimeOffset DateOccurred { get; protected set; } = DateTimeOffset.UtcNow;
}