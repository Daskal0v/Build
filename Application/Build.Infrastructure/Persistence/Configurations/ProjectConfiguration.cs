namespace Build.Infrastructure.Persistence.Configurations;

using Build.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure (EntityTypeBuilder<Project> builder)
    {
    }
}
