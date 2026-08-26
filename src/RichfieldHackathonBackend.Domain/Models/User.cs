using RichfieldHackathonBackend.Domain.Enums;
namespace RichfieldHackathonBackend.Domain.Models;

public class User : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; }

    // 1:1 Optional Navigations
    public Student? Student { get; set; }
    public Alumni? Alumni { get; set; }
    public Admin? Admin { get; set; }
}
