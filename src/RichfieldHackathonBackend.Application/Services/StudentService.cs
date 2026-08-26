using RichfieldHackathonBackend.Application.Dtos.Student;
using RichfieldHackathonBackend.Application.Mappings;
using RichfieldHackathonBackend.Domain.Interfaces;

namespace RichfieldHackathonBackend.Application.Services;

public class StudentService
{
    private readonly IStudentRepo _repo;
    private readonly StudentMappers _mapper;

    public StudentService(IStudentRepo repo, StudentMappers mapppers)
    {
        _repo = repo;
        _mapper = mapppers;
    }
    public async Task<ICollection<GetStudentDto>> GetAll()
    {
        var enties = await _repo.GetStudents();
        var students = enties.Select(x => _mapper.MapToDto(x)).ToList();
        if (students.Count == 0) return [];
        return students;
    }
    public async Task<GetStudentDto> Post(PostStudentDto dto, Guid userId)
    {
        var entity = _mapper.MapToEntity(dto);
        var res = await _repo.CreateStudentProfileAsync(entity, userId);
        return _mapper.MapToDto(res);

    }
    public async Task<GetStudentDto> Put(PutStudentDto dto, Guid userId)
    {
        var entity = _mapper.MapToEntityFromUpdate(dto);
        var res = await _repo.UpdateStudentProfileAsync(userId, entity);
        return _mapper.MapToDto(res);
    }

}