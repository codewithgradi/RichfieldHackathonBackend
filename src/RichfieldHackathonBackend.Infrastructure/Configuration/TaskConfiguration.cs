using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainTask = RichfieldHackathonBackend.Domain.Models.Task;
namespace RichfieldHackathonBackend.Infrastructure.Configuration;

public class TaskConfiguration : IEntityTypeConfiguration<DomainTask>
{
    public void Configure(EntityTypeBuilder<DomainTask> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(t => t.Instructions)
            .IsRequired();

        builder.HasOne(t => t.CreatedByAdmin)
            .WithMany(a => a.CreatedTasks)
            .HasForeignKey(t => t.CreatedByAdminId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(t => t.SuggestedByAlumni)
            .WithMany(a => a.SuggestedTasks)
            .HasForeignKey(t => t.SuggestedByAlumniId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
