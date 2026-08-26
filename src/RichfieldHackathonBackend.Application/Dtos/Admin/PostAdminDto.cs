using System.ComponentModel.DataAnnotations;
namespace RichfieldHackathonBackend.Application.Dtos.Admin;

public class PostAdminDto
{
    [Required(ErrorMessage = "user id may not be null")]
    public Guid UserId { get; set; }
    [Required(ErrorMessage = "fullname may not be null")]

    public string FullName { get; set; } = string.Empty;
    [Required(ErrorMessage = "department  may not be null")]

    public string Department { get; set; } = string.Empty;

}
