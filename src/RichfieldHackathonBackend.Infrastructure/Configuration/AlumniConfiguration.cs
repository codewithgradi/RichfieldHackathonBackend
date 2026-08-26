using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichfieldHackathonBackend.Domain.Models;

namespace RichfieldHackathonBackend.Infrastructure.Configuration;

public class AlumniConfiguration : IEntityTypeConfiguration<Alumni>
{
    public void Configure(EntityTypeBuilder<Alumni> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.FullName)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(a => a.Company)
            .HasMaxLength(150);

        builder.Property(a => a.JobTitle)
            .HasMaxLength(150);
    }
}
