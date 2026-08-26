using RichfieldHackathonBackend.Application.Dtos.Career;
using RichfieldHackathonBackend.Application.Dtos.Mentorship;
using RichfieldHackathonBackend.Application.Dtos.Task;
using RichfieldHackathonBackend.Application.Dtos.User;
namespace RichfieldHackathonBackend.Application.Dtos.Alumni;

public class GetAlumniDto 
{
    public Guid UserId { get; set; }
    public GetUserDto User { get; set; } = null!;

    public string FullName { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;
    public string LinkedInUrl { get; set; } = string.Empty;

    public Guid CareerId { get; set; }
    public GetCareerDto Career { get; set; } = null!;

    // Navigation Properties
    public ICollection<GetMentorshipDto> Mentorships { get; set; } = new List<GetMentorshipDto>();
    public ICollection<GetTaskDto> SuggestedTasks { get; set; } = new List<GetTaskDto>();
}