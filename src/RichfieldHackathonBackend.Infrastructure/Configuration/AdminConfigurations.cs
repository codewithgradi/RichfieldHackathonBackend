using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichfieldHackathonBackend.Domain.Models;

namespace RichfieldHackathonBackend.Infrastructure.Configuration;

public class AdminConfiguration : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.FullName)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(a => a.Department)
            .HasMaxLength(100);
    }
}
