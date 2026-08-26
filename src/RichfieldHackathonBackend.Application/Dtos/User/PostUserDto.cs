using System.ComponentModel.DataAnnotations;
using RichfieldHackathonBackend.Domain.Enums;
namespace RichfieldHackathonBackend.Application.Dtos.User;

public class PostUserDto
{
    [Required(ErrorMessage = "email is require")]
    public string Email { get; set; } = string.Empty;
    [Required(ErrorMessage = "password is require")]

    public string PasswordHash { get; set; } = string.Empty;
    [Required(ErrorMessage = "role is require")]

    public UserRole Role { get; set; }
}
