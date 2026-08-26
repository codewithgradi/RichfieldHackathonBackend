namespace RichfieldHackathonBackend.Domain.Models;

using RichfieldHackathonBackend.Domain.Enums;
public class Mentorship : BaseEntity
{
    public Guid StudentId { get; set; }
    public Student Student { get; set; } = null!;

    public Guid AlumniId { get; set; }
    public Alumni Alumni { get; set; } = null!;

    public MentorshipStatus Status { get; set; } = MentorshipStatus.Pending;
}
