using RichfieldHackathonBackend.Application.Dtos.Career;
using RichfieldHackathonBackend.Application.Dtos.Certification;
using RichfieldHackathonBackend.Application.Dtos.Mentorship;
using RichfieldHackathonBackend.Application.Dtos.TaskSubmission;

namespace RichfieldHackathonBackend.Application.Dtos.Student;

public class GetStudentDto
{
    public Guid UserId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string StudentNumber { get; set; } = string.Empty;
    public int YearOfStudy { get; set; }

    public Guid TargetCareerId { get; set; }
    public GetCareerDto TargetCareer { get; set; } = null!;

    // Navigation Properties
    public ICollection<GetMentorshipDto> Mentorships { get; set; }
    public ICollection<GetTaskSubmissionDto> Submissions { get; set; }
    public ICollection<GetCertificationDto> Certifications { get; set; }
}
