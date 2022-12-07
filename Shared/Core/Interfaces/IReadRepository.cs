namespace Build.Shared.Core.Interfaces;

public interface IReadRepository<T> where T : class, IAggregateRoot
{
  /// <summary>
  /// Finds all entities of <typeparamref name="T" /> from the database.
  /// </summary>
  /// <returns>
  /// A task that represents the asynchronous operation.
  /// The task result contains a <see cref="List{T}" /> that contains elements from the input sequence.
  /// </returns>
  Task<List<T>> ListAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Finds all entities of <typeparamref name="T" />, that matches the encapsulated query logic of the
  /// <paramref name="specification"/>, from the database.
  /// </summary>
  /// <param name="specification">The encapsulated query logic.</param>
  /// <returns>
  /// A task that represents the asynchronous operation.
  /// The task result contains a <see cref="List{T}" /> that contains elements from the input sequence.
  /// </returns>
  Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

  /// <summary>
  /// Finds first entity of <typeparamref name="T" /> from the database.
  /// </summary>
  /// <returns>
  /// A task that represents the asynchronous operation.
  /// The task result contains a <see cref="{T}" /> that contains first element from the input sequence.
  /// </returns>
  Task<T> FirstOrDefaultAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Finds first entity of <typeparamref name="T" />, that matches the encapsulated query logic of the
  /// <paramref name="specification"/>, from the database.
  /// </summary>
  /// <param name="specification">The encapsulated query logic.</param>
  /// <returns>
  /// A task that represents the asynchronous operation.
  /// The task result contains a <see cref="{T}" /> that contains first element from the input sequence.
  /// </returns>
  Task<T> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

  /// <summary>
  /// Returns the total number of records.
  /// </summary>
  /// <returns>
  /// A task that represents the asynchronous operation. The task result contains the
  /// number of elements in the input sequence.
  /// </returns>
  Task<long> CountAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Returns a number that represents how many entities satisfy the encapsulated query logic
  /// of the <paramref name="specification"/>.
  /// </summary>
  /// <param name="specification">The encapsulated query logic.</param>
  /// <returns>
  /// A task that represents the asynchronous operation. The task result contains the
  /// number of elements in the input sequence.
  /// </returns>
  Task<long> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);

  /// <summary>
  /// Returns a boolean whether any entity exists or not.
  /// </summary>
  /// <returns>
  /// A task that represents the asynchronous operation. The task result contains true if the 
  /// source sequence contains any elements; otherwise, false.
  /// </returns>
  Task<bool> AnyAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Returns a boolean that represents whether any entity satisfy the encapsulated query logic
  /// of the <paramref name="specification"/> or not.
  /// </summary>
  /// <param name="specification">The encapsulated query logic.</param>
  /// <returns>
  /// A task that represents the asynchronous operation. The task result contains true if the 
  /// source sequence contains any elements; otherwise, false.
  /// </returns>
  Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);
}
