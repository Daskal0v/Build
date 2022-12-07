namespace Build.Application;
public class BaseRequest<T>
{
    /// <summary>
    /// Simple property which provide ability to track all of the requests trought the system
    /// </summary>
    public Guid UID { get; set; } = Guid.NewGuid();
    T Data { get; set; }
}