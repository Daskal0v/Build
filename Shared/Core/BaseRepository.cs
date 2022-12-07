namespace Build.Shared.Core;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Build.Shared.Core.Interfaces;

public abstract class BaseRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : class, IAggregateRoot
{
  public Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<bool> AnyAsync(CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<long> CountAsync(CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<long> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<T> DeleteAsync(T entity, CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<List<T>> DeleteAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<T> FirstOrDefaultAsync(CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<T> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<List<T>> ListAsync(CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }

  public Task<List<T>> UpdateAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
  {
    throw new NotImplementedException();
  }
}