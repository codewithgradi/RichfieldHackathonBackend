namespace RichfieldHackathonBackend.Application.Dtos.TaskSubmission;

using System.ComponentModel.DataAnnotations;
public class PostTaskSubmissionDto
{
    [Required(ErrorMessage = "Task Id can not be null")]
    public Guid TaskId { get; set; }
    [Required(ErrorMessage = "Student id Id can not be null")]
    public Guid StudentId { get; set; }
    [Required(ErrorMessage = "Missing submission urls")]
    public ICollection<string> SubmissionUrl { get; set; }
}
