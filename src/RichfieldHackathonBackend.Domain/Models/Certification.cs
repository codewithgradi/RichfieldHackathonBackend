namespace RichfieldHackathonBackend.Domain.Models;

public class Certification : BaseEntity
{
    public Guid SubmissionId { get; set; }
    public TaskSubmission Submission { get; set; } = null!;

    public Guid StudentId { get; set; }
    public Student Student { get; set; } = null!;

    public string CertificateCode { get; set; } = string.Empty;
    public DateTime IssuedAt { get; set; } = DateTime.UtcNow;
}