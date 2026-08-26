using System.ComponentModel.DataAnnotations;

namespace RichfieldHackathonBackend.Application.Dtos.Student;

public class PostStudentDto
{
    [Required(ErrorMessage = "user id may not be null")]
    public Guid UserId { get; set; }
    [Required(ErrorMessage = "fullname may not be null")]

    public string FullName { get; set; } = string.Empty;
    [Required(ErrorMessage = "student number may not be null")]
    public string StudentNumber { get; set; } = string.Empty;
    [Required(ErrorMessage = "year of study may not be null")]
    public int YearOfStudy { get; set; }
    [Required(ErrorMessage = "target career may not be null")]
    public Guid TargetCareerId { get; set; }

}
