using RichfieldHackathonBackend.Domain.Interfaces;

namespace RichfieldHackathonBackend.Application.Services;

public class StudentService
{
    private readonly IStudentRepo _repo;

    public StudentService(IStudentRepo repo)
    {
        _repo = repo;
    }
}