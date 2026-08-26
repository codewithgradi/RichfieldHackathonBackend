using System.ComponentModel.DataAnnotations;

namespace RichfieldHackathonBackend.Application.Dtos.Task;

public class PostTaskDto
{
    [Required(ErrorMessage = "Task needs a title")]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = "Task needs a instructions")]
    public string Instructions { get; set; }
    [Required(ErrorMessage = "Task needs a Admin id")]
    public Guid CreatedByAdminId { get; set; }
    public Guid? SuggestedByAlumniId { get; set; }

}
