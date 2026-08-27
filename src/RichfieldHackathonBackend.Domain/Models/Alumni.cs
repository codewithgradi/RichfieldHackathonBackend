namespace RichfieldHackathonBackend.Domain.Models;
public class Alumni : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public string FullName { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;
    public string LinkedInUrl { get; set; } = string.Empty;

    public Guid CareerId { get; set; }
    public Career Career { get; set; } = null!;

    // Navigation Properties
    public ICollection<Mentorship> Mentorships { get; set; } = new List<Mentorship>();
    public ICollection<Task> SuggestedTasks { get; set; } = new List<Task>();
}