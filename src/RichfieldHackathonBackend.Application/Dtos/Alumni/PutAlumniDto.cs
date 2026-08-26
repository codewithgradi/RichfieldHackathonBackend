using System.ComponentModel.DataAnnotations;

namespace RichfieldHackathonBackend.Application.Dtos.Alumni;

public class PutAlumniDto
{
    [Required(ErrorMessage = "user id may not be null")]
    public Guid UserId { get; set; }
    [Required(ErrorMessage = "fullname may not be null")]

    public string FullName { get; set; } = string.Empty;
    [Required(ErrorMessage = "company may not be null")]

    public string Company { get; set; } = string.Empty;
    [Required(ErrorMessage = "job title may not be null")]

    public string JobTitle { get; set; } = string.Empty;
    [Required(ErrorMessage = "linked may not be null")]

    public string LinkedInUrl { get; set; } = string.Empty;
    [Required(ErrorMessage = "career id may not be null")]
    public Guid CareerId { get; set; }

}