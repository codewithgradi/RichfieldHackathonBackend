using RichfieldHackathonBackend.Application.Dtos.Student;
using RichfieldHackathonBackend.Application.Dtos.TaskSubmission;

namespace RichfieldHackathonBackend.Application.Dtos.Certification;

public class GetCertificationDto
{
    public Guid SubmissionId { get; set; }
    public GetTaskSubmissionDto Submission { get; set; }

    public Guid StudentId { get; set; }
    public GetStudentDto Student { get; set; }

    public string CertificateCode { get; set; }
    public DateTime IssuedAt { get; set; }
}