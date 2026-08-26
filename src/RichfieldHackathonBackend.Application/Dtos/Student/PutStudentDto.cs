using System.ComponentModel.DataAnnotations;

namespace RichfieldHackathonBackend.Application.Dtos.Student;

public class PutStudentDto
{
    [Required(ErrorMessage = "name can not be null")]
    public string FullName { get; set; } = string.Empty;
    [Required(ErrorMessage = "student number can not be null")]

    public string StudentNumber { get; set; } = string.Empty;
    [Required(ErrorMessage = "year of  can not be null")]

    public int YearOfStudy { get; set; }
    [Required(ErrorMessage = "target career can not be null")]

    public Guid TargetCareerId { get; set; }
}
