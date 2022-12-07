namespace Build.Infrastructure.Persistence.DbContexts;

using System.Reflection;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Application DB Context.
/// </summary>
public class ApplicationDbContext : DbContext
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
    /// </summary>
    /// <param name="options">Options.</param>
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    /// <inheritdoc/>
    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
