namespace RichfieldHackathonBackend.Domain.Models;
using RichfieldHackathonBackend.Domain.Enums;
public class Task : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Instructions { get; set; } = string.Empty;
    public TaskStatus Status { get; set; } = TaskStatus.Active;

    public Guid CreatedByAdminId { get; set; }
    public Admin CreatedByAdmin { get; set; } = null!;

    public Guid? SuggestedByAlumniId { get; set; }
    public Alumni? SuggestedByAlumni { get; set; }

    // Navigation Properties
    public ICollection<TaskSubmission> Submissions { get; set; } = new List<TaskSubmission>();
}
