namespace Build.Infrastructure.Persistence.Repositories;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Build.Application.EntityCQRS.Queries;
using Build.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

public abstract class BaseRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : class, IAggregateRoot
{
    private readonly DbContext dbContext;

    public BaseRepository (DbContext dbContext)
    {
        dbContext = dbContext;
    }

    protected abstract IQueryable<T> ConfigQuery (IQueryable<T> queryable);

    /// <inheritdoc/>
    public Task<bool> AnyAsync (CancellationToken cancellationToken = default)
    {
        return GetReadQuery().Queryable.AnyAsync();
    }

    /// <inheritdoc/>
    public Task<bool> AnyAsync (ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return GetSpecificationQuery(specification).Queryable.AnyAsync();
    }

    /// <inheritdoc/>
    public async Task<long> CountAsync (CancellationToken cancellationToken = default)
    {
        return await GetReadQuery().Queryable.CountAsync();
    }

    /// <inheritdoc/>
    public async Task<long> CountAsync (ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return await GetSpecificationQuery(specification).Queryable.CountAsync();
    }

    /// <inheritdoc/>
    public Task<List<T>> ListAsync (CancellationToken cancellationToken = default)
    {
        return GetReadQuery().Queryable.ToListAsync();
    }

    /// <inheritdoc/>
    public Task<List<T>> ListAsync (ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return GetSpecificationQuery(specification).Queryable.ToListAsync();
    }

    /// <inheritdoc/>
    public Task<T> FirstOrDefaultAsync (CancellationToken cancellationToken = default)
    {
        return GetReadQuery().Queryable.FirstOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public Task<T> FirstOrDefaultAsync (ISpecification<T> specification, CancellationToken cancellationToken = default)
    {
        return GetSpecificationQuery(specification).Queryable.FirstOrDefaultAsync(cancellationToken);
    }

    private BaseQuery<T> GetReadQuery ()
    {
        return new BaseQuery<T>(ConfigQuery(dbContext.Set<T>()));
    }

    private BaseQuery<T> GetSpecificationQuery (ISpecification<T> specification)
    {
        return (BaseQuery<T>) specification.Apply(GetReadQuery());
    }

    /// <inheritdoc/>
    public async Task<T> AddAsync (T entity, CancellationToken cancellationToken = default)
    {
        await dbContext.Set<T>().AddAsync(entity, cancellationToken);
        await SaveChangesAsync(cancellationToken);
        return entity;
    }

    /// <inheritdoc/>
    public async Task<T> DeleteAsync (T entity, CancellationToken cancellationToken = default)
    {
        dbContext.Set<T>().Remove(entity);
        await SaveChangesAsync(cancellationToken);
        return entity;
    }

    /// <inheritdoc/>
    public async Task<List<T>> DeleteAsync (IEnumerable<T> entities, CancellationToken cancellationToken = default)
    {
        var entitiesList = entities.ToList();
        dbContext.Set<T>().RemoveRange(entitiesList);
        await SaveChangesAsync(cancellationToken);
        return entitiesList;
    }

    /// <inheritdoc/>
    public async Task<T> UpdateAsync (T entity, CancellationToken cancellationToken = default)
    {
        dbContext.Set<T>().Update(entity);
        await SaveChangesAsync(cancellationToken);
        return entity;
    }

    /// <inheritdoc/>
    public async Task<List<T>> UpdateAsync (IEnumerable<T> entities, CancellationToken cancellationToken = default)
    {
        var entitiesList = entities.ToList();
        dbContext.Set<T>().UpdateRange(entitiesList);
        await SaveChangesAsync(cancellationToken);
        return entitiesList;
    }

    private async Task SaveChangesAsync (CancellationToken cancellationToken = default)
    {
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}