using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichfieldHackathonBackend.Domain.Models;

namespace RichfieldHackathonBackend.Infrastructure.Configuration;

public class CareerConfiguration : IEntityTypeConfiguration<Career>
{
    public void Configure(EntityTypeBuilder<Career> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Title)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(c => c.Description)
            .HasMaxLength(1000);

        builder.HasMany(c => c.Students)
            .WithOne(s => s.TargetCareer)
            .HasForeignKey(s => s.TargetCareerId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.Alumni)
            .WithOne(a => a.Career)
            .HasForeignKey(a => a.CareerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
