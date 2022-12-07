namespace Build.Shared.Core;

public abstract class BaseEntity<T>
{
    /// <summary>
    /// Gets or sets Entitiy Id
    /// </summary>
    public T Id { get; set; }

    /// <summary>
    /// Gets or sets the Created date for the enitiy.
    /// </summary>
    public DateTimeOffset CreatedDate { get; set; }

}