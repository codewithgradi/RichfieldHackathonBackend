using System.ComponentModel.DataAnnotations;
namespace RichfieldHackathonBackend.Application.Dtos.Application;

public class PostApplicationDto
{
    [Required]
    public Guid UserId { get; set; }

}