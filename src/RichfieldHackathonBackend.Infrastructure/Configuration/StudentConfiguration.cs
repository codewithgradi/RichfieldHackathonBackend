using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichfieldHackathonBackend.Domain.Models;

namespace RichfieldHackathonBackend.Infrastructure.Configuration;


public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.FullName)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(s => s.StudentNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(s => s.StudentNumber)
            .IsUnique();
    }
}