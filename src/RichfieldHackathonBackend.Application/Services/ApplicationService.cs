using RichfieldHackathonBackend.Application.Dtos.Application;
using RichfieldHackathonBackend.Application.Mappings;
using RichfieldHackathonBackend.Domain.Interfaces;

public class ApplicationService
{
    private readonly IApplicationRepo _repo;
    private readonly AdminMappers _mapper;

    public ApplicationService(IApplicationRepo repo, AdminMappers mappers)
    {
        _repo = repo;
        _mapper = mappers;
    }
    public async Task<GetApplicationDto> Post(PostApplicationDto dto, Guid userId)
    {
        var entity = _mapper.MapAppToEntity(dto);
        var res = await _repo.Post(entity, userId);
        return _mapper.MapAppToDto(res);
    }
    public async Task<ICollection<GetApplicationDto>> GetAll()
    {

        var entities = await _repo.GetAll();
        var res = entities.Select(x => _mapper.MapAppToDto(x)).ToList();
        return res;

    }
    public async Task<GetApplicationDto> Get()
    {
        var application = await _repo.Get();
        var res = _mapper.MapAppToDto(application);
        return res;

    }
    public async Task<GetApplicationDto> Put()
    {
        var application = await _repo.Update();
        var res = _mapper.MapAppToDto(application);
        return res;

    }
}