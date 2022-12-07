namespace Build.Domain.Interfaces;
public interface IWriteRepository<T> where T : class, IAggregateRoot
{
    /// <summary>
    /// Adds an entity in the database.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// The task result contains the <typeparamref name="T" />.
    /// </returns>
    Task<T> AddAsync (T entity, CancellationToken cancellationToken = default);
    /// <summary>
    /// Updates an entity in the database
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task<T> UpdateAsync (T entity, CancellationToken cancellationToken = default);
    /// <summary>
    /// Updates entities in the database
    /// </summary>
    /// <param name="entity">The entities to update.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task<List<T>> UpdateAsync (IEnumerable<T> entities, CancellationToken cancellationToken = default);
    /// <summary>
    /// Removes an entity in the database
    /// </summary>
    /// <param name="entity">The entity to delete.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task<T> DeleteAsync (T entity, CancellationToken cancellationToken = default);
    /// <summary>
    /// Removes enities in the database
    /// </summary>
    /// <param name="entities">The entities to delete.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task<List<T>> DeleteAsync (IEnumerable<T> entities, CancellationToken cancellationToken = default);
}
