namespace RichfieldHackathonBackend.Domain.Models;

public class Admin : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public string FullName { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;

    // Navigation Properties
    public ICollection<Task> CreatedTasks { get; set; } = new List<Task>();
    public ICollection<TaskSubmission> VerifiedSubmissions { get; set; } = new List<TaskSubmission>();
}
