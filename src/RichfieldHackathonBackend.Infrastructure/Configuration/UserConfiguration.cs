using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichfieldHackathonBackend.Domain.Models;

namespace RichfieldHackathonBackend.Infrastructure.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(256);

        builder.HasIndex(u => u.Email)
            .IsUnique();

        // 1:1 Relationships
        builder.HasOne(u => u.Admin)
            .WithOne(a => a.User)
            .HasForeignKey<Admin>(a => a.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(u => u.Student)
            .WithOne(s => s.User)
            .HasForeignKey<Student>(s => s.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(u => u.Alumni)
            .WithOne(a => a.User)
            .HasForeignKey<Alumni>(a => a.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}








