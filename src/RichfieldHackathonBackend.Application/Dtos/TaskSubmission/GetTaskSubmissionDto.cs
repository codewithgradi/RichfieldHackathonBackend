namespace RichfieldHackathonBackend.Application.Dtos.TaskSubmission;

using RichfieldHackathonBackend.Application.Dtos.Admin;
using RichfieldHackathonBackend.Application.Dtos.Student;
using RichfieldHackathonBackend.Application.Dtos.Task;
using RichfieldHackathonBackend.Domain.Enums;
using RichfieldHackathonBackend.Domain.Models;

public class GetTaskSubmissionDto
{
    public Guid TaskId { get; set; }
    public GetTaskDto Task { get; set; } = null!;

    public Guid StudentId { get; set; }
    public GetStudentDto Student { get; set; } = null!;
    public ICollection<string> SubmissionUrl { get; set; }
    public SubmissionStatus Status { get; set; }
    public Guid? VerifiedByAdminId { get; set; }
    public GetAdminDto? VerifiedByAdmin { get; set; }
}
