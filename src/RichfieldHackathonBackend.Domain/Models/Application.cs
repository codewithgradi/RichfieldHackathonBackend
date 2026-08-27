using RichfieldHackathonBackend.Domain.Models;
namespace RichfieldHackathonBackend.Domain.Models;

public class Application : User
{
    public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;
    public Guid UserId { get; set; }

    public User? User { get; set; }
}