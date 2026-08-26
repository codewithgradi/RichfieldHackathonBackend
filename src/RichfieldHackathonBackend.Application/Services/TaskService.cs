using RichfieldHackathonBackend.Application.Dtos.Task;
using RichfieldHackathonBackend.Application.Mappings;

namespace RichfieldHackathonBackend.Application.Services;

public class TaskService
{
    private readonly ITaskRepo _repo;
    private readonly AdminMappers _mapper;

    public TaskService(ITaskRepo repo, AdminMappers mappers)
    {
        _repo = repo;
        _mapper = mappers;
    }
    public async Task<GetTaskDto> Post(PostTaskDto dto, Guid userId)
    {
        var entity = _mapper.MapTaskToEntity(dto);
        var res = await _repo.CreateTaskAsync(entity, userId);
        return _mapper.MapTaskToDto(res);
    }
    public async Task<ICollection<GetTaskDto>> GetAll()
    {

        var entities = await _repo.GetAllTasks();
        var res = entities.Select(x => _mapper.MapTaskToDto(x)).ToList();
        return res;

    }
}