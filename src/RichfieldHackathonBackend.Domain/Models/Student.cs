namespace RichfieldHackathonBackend.Domain.Models;
public class Student : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public string FullName { get; set; } = string.Empty;
    public string StudentNumber { get; set; } = string.Empty;
    public int YearOfStudy { get; set; }

    public Guid TargetCareerId { get; set; }
    public Career TargetCareer { get; set; } = null!;

    // Navigation Properties
    public ICollection<Mentorship> Mentorships { get; set; } = new List<Mentorship>();
    public ICollection<TaskSubmission> Submissions { get; set; } = new List<TaskSubmission>();
    public ICollection<Certification> Certifications { get; set; } = new List<Certification>();
}
