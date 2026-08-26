using System.ComponentModel.DataAnnotations;

namespace RichfieldHackathonBackend.Application.Dtos.Career;

public class PostCareerDto
{
    [Required(ErrorMessage = "title can not be null")]
    public string Title { get; set; }
    [Required(ErrorMessage = "description can not be null")]

    public string Description { get; set; }
    [Required(ErrorMessage = "required can not be null")]

    public ICollection<string> RequiredSkills { get; set; }
}
