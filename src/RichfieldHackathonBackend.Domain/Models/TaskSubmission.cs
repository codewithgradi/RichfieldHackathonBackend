namespace RichfieldHackathonBackend.Domain.Models;

using RichfieldHackathonBackend.Domain.Enums;
public class TaskSubmission : BaseEntity
{
    public Guid TaskId { get; set; }
    public Task Task { get; set; } = null!;

    public Guid StudentId { get; set; }
    public Student Student { get; set; } = null!;

    public string SubmissionUrl { get; set; } = string.Empty;
    public SubmissionStatus Status { get; set; } = SubmissionStatus.Submitted;

    public Guid? VerifiedByAdminId { get; set; }
    public Admin? VerifiedByAdmin { get; set; }

    // 1:1 Navigation
    public Certification? Certification { get; set; }
}
