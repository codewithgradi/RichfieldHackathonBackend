using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RichfieldHackathonBackend.Domain.Models;

namespace RichfieldHackathonBackend.Infrastructure.Configuration;

public class TaskSubmissionConfiguration : IEntityTypeConfiguration<TaskSubmission>
{
    public void Configure(EntityTypeBuilder<TaskSubmission> builder)
    {
        builder.HasKey(ts => ts.Id);

        builder.Property(ts => ts.SubmissionUrl)
            .IsRequired()
            .HasMaxLength(500);

        builder.HasOne(ts => ts.Task)
            .WithMany(t => t.Submissions)
            .HasForeignKey(ts => ts.TaskId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ts => ts.Student)
            .WithMany(s => s.Submissions)
            .HasForeignKey(ts => ts.StudentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(ts => ts.VerifiedByAdmin)
            .WithMany(a => a.VerifiedSubmissions)
            .HasForeignKey(ts => ts.VerifiedByAdminId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
