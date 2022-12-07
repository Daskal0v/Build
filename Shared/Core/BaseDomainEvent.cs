namespace Build.Shared.Core;

public abstract class BaseDomainEvent
{
  public DateTimeOffset DateOccurred { get; protected set; } = DateTimeOffset.UtcNow;
}