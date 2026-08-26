namespace RichfieldHackathonBackend.Application.Dtos.Task;

using RichfieldHackathonBackend.Application.Dtos.TaskSubmission;
using RichfieldHackathonBackend.Domain.Enums;
using RichfieldHackathonBackend.Domain.Models;

public class GetTaskDto
{
    public string Title { get; set; } 
    public string Instructions { get; set; } 
    public TaskStatus Status { get; set; } 

    public Guid CreatedByAdminId { get; set; }
    public GetAdminDto CreatedByAdmin { get; set; } 

    public Guid? SuggestedByAlumniId { get; set; }
    public GetAlumniDto? SuggestedByAlumni { get; set; }

    // Navigation Properties
    public ICollection<GetTaskSubmissionDto> Submissions { get; set; } = new List<GetTaskSubmissionDto>();
}
