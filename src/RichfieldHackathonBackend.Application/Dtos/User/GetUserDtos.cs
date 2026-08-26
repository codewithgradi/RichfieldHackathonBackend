using RichfieldHackathonBackend.Application.Dtos.Admin;
using RichfieldHackathonBackend.Application.Dtos.Alumni;
using RichfieldHackathonBackend.Application.Dtos.Student;
using RichfieldHackathonBackend.Domain.Enums;
namespace RichfieldHackathonBackend.Application.Dtos.User;

public class GetUserDto
{
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; }

    public GetStudentDto? Student { get; set; }
    public GetAlumniDto? Alumni { get; set; }
    public GetAdminDto? Admin { get; set; }
}
