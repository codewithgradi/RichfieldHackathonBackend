namespace RichfieldHackathonBackend.Domain.Models;

public class Career : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<string> RequiredSkills { get; set; } = new List<string>();

    // Navigation Properties
    public ICollection<Student> Students { get; set; } = new List<Student>();
    public ICollection<Alumni> Alumni { get; set; } = new List<Alumni>();
}
