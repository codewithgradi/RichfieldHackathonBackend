using RichfieldHackathonBackend.Application.Dtos.Task;
using RichfieldHackathonBackend.Application.Dtos.TaskSubmission;
using RichfieldHackathonBackend.Application.Dtos.User;

namespace RichfieldHackathonBackend.Application.Dtos.Admin;

public class GetAdminDto
{
    public Guid UserId { get; set; }
    public GetUserDto User { get; set; } = null!;

    public string FullName { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;

    // Navigation Properties
    public ICollection<GetTaskDto> CreatedTasks { get; set; } = new List<GetTaskDto>();
    public ICollection<GetTaskSubmissionDto> VerifiedSubmissions { get; set; } = new List<GetTaskSubmissionDto>();
}
