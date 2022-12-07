namespace Build.Identity.Infrastructure.Persistence.DbContexts;

using Build.Identity.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class IdentityContext : IdentityDbContext<User>
{

    public IdentityContext (DbContextOptions<IdentityContext> options): base(options)
    {

    }
    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
