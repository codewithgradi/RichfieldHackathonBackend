using RichfieldHackathonBackend.Application.Dtos.Career;
using RichfieldHackathonBackend.Application.Dtos.Student;
using RichfieldHackathonBackend.Domain.Models;
using Riok.Mapperly.Abstractions;
namespace RichfieldHackathonBackend.Application.Mappings;

[Mapper]
public partial class StudentMappers
{
    public partial Student MapToEntity(PostStudentDto dto);
    public partial GetStudentDto MapToDto(Student ent);
}