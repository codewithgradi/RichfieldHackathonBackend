namespace RichfieldHackathonBackend.Application.Dtos.Mentorship;

using RichfieldHackathonBackend.Application.Dtos.Alumni;
using RichfieldHackathonBackend.Application.Dtos.Student;
using RichfieldHackathonBackend.Domain.Enums;
public class GetMentorshipDto
{
    public Guid StudentId { get; set; }
    public GetStudentDto Student { get; set; }

    public Guid AlumniId { get; set; }
    public GetAlumniDto Alumni { get; set; }

    public MentorshipStatus Status { get; set; }
}
