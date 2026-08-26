namespace RichfieldHackathonBackend.Domain.Models;

public class Career : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string RequiredSkills { get; set; } = string.Empty;

    // Navigation Properties
    public ICollection<Student> Students { get; set; } = new List<Student>();
    public ICollection<Alumni> Alumni { get; set; } = new List<Alumni>();
}
