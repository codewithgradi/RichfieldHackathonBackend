using RichfieldHackathonBackend.Domain.Interfaces;
using RichfieldHackathonBackend.Domain.Models;
namespace RichfieldHackathonBackend.Infrastructure.Repo;

public class StudentRepo : IStudentRepo
{
    public Task<Student> CreateStudentProfileAsync(Student student, Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<Student> GetStudentProfileAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Student>> GetStudents()
    {
        throw new NotImplementedException();
    }

    public Task<Student> UpdateStudentProfileAsync(Guid id, Student student)
    {
        throw new NotImplementedException();
    }
}