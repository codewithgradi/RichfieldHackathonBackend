using RichfieldHackathonBackend.Application.Dtos.TaskSubmission;
using RichfieldHackathonBackend.Application.Mappings;
using RichfieldHackathonBackend.Domain.Exceptions;
namespace RichfieldHackathonBackend.Application.Services;
public class TaskSubService
{
    private readonly ITaskSubRepo _repo;
    private readonly AdminMappers _mapper;

    public TaskSubService(ITaskSubRepo repo, AdminMappers mappers)
    {
        _repo = repo;
        _mapper = mappers;
    }
    public async Task<GetTaskSubmissionDto> Post(PostTaskSubmissionDto dto, Guid userId)
    {
        var entity = _mapper.MapTaskSubmisionToEntity(dto);
        var res = await _repo.CreateTaskSubAsync(entity, userId);
        return _mapper.MapTaskSubmisionToDto(res);
    }
    public async Task<ICollection<GetTaskSubmissionDto>> GetAll()
    {

        var entities = await _repo.GetAllTaskSubs();
        var res = entities.Select(x => _mapper.MapTaskSubmisionToDto(x)).ToList();
        return res;

    }
    public async Task<ICollection<GetTaskSubmissionDto>> GetAllByStudentId(Guid studentId)
    {
        var entity = await _repo.GetAllTaskSubsByStudentId(studentId);
        if (entity == null) throw new ReasourceNotFoundException("Student not found");
        var res = entity.Select(x => _mapper.MapTaskSubmisionToDto(x)).ToList();
        return res;
    }
}