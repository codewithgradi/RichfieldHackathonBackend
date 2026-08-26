namespace RichfieldHackathonBackend.Application.Dtos.Mentorship;

using System.ComponentModel.DataAnnotations;
using RichfieldHackathonBackend.Application.Dtos.Alumni;
using RichfieldHackathonBackend.Application.Dtos.Student;
using RichfieldHackathonBackend.Domain.Enums;
public class PostMentorshipDto
{
    [Required(ErrorMessage = "student id can not be null")]

    public Guid StudentId { get; set; }
    [Required(ErrorMessage = "alumni id  can not be null")]


    public Guid AlumniId { get; set; }
}
