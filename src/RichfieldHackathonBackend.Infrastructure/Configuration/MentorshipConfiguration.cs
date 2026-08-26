using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichfieldHackathonBackend.Domain.Models;

namespace RichfieldHackathonBackend.Infrastructure.Configuration;

public class MentorshipConfiguration : IEntityTypeConfiguration<Mentorship>
{
    public void Configure(EntityTypeBuilder<Mentorship> builder)
    {
        builder.HasKey(m => m.Id);

        builder.HasOne(m => m.Student)
            .WithMany(s => s.Mentorships)
            .HasForeignKey(m => m.StudentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(m => m.Alumni)
            .WithMany(a => a.Mentorships)
            .HasForeignKey(m => m.AlumniId)
            .OnDelete(DeleteBehavior.Restrict);

        // Prevent duplicate mentorship connections between the same pair
        builder.HasIndex(m => new { m.StudentId, m.AlumniId })
            .IsUnique();
    }
}
