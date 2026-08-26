using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichfieldHackathonBackend.Domain.Models;

namespace RichfieldHackathonBackend.Infrastructure.Configuration;

public class CertificationConfiguration : IEntityTypeConfiguration<Certification>
{
    public void Configure(EntityTypeBuilder<Certification> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.CertificateCode)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(c => c.CertificateCode)
            .IsUnique();

        // 1:1 relationship with TaskSubmission
        builder.HasOne(c => c.Submission)
            .WithOne(ts => ts.Certification)
            .HasForeignKey<Certification>(c => c.SubmissionId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(c => c.Student)
            .WithMany(s => s.Certifications)
            .HasForeignKey(c => c.StudentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
