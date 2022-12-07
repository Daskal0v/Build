namespace Build.Shared.Communication;
public abstract class BaseRequest
{
  /// <summary>
  /// Simple property which provide ability to track all of the requests trought the system
  /// </summary>
  public Guid UID { get; set; } = Guid.NewGuid();
}