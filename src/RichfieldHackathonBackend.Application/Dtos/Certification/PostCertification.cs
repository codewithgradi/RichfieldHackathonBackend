
using System.ComponentModel.DataAnnotations;

namespace RichfieldHackathonBackend.Application.Dtos.Certification;

public class PostCertificationDto
{
    [Required(ErrorMessage = "sub id needed")]
    public Guid SubmissionId { get; set; }
    [Required(ErrorMessage = "student id needed")]

    public Guid StudentId { get; set; }
}