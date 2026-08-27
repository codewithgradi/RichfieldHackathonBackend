using RichfieldHackathonBackend.Application.Dtos.User;

namespace RichfieldHackathonBackend.Application.Dtos.Application;

public class GetApplicationDto
{
    public ApplicationStatus Status { get; set; }
    public Guid UserId { get; set; }

    public GetUserDto? User { get; set; }
}