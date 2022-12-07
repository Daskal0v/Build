namespace Build.Infrastructure.Persistence.Repositories;

using System;
using System.Linq;
using Build.Domain.Interfaces;
using Build.Infrastructure.Persistence.DbContexts;

public class Repository<T> : BaseRepository<T> where T : class, IAggregateRoot
{
    public Repository (ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    protected override IQueryable<T> ConfigQuery (IQueryable<T> queryable)
    {
        throw new NotImplementedException();
    }
}
