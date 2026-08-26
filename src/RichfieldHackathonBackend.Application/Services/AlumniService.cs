using RichfieldHackathonBackend.Application.Dtos.Alumni;
using RichfieldHackathonBackend.Application.Mappings;
using RichfieldHackathonBackend.Domain.Interfaces;

namespace RichfieldHackathonBackend.Application.Services;

public class AlumniService
{
    private readonly IAlumniRepo _repo;
    private readonly AlumniMappers _mapper;

    public AlumniService(IAlumniRepo alumniRepo, AlumniMappers mappers)
    {
        _repo = alumniRepo;
        _mapper = mappers;
    }
    public async Task<ICollection<GetAlumniDto>> Get()
    {
        var enties = await _repo.GetAllAlumni();
        var alumnus = enties.Select(x => _mapper.MapToGet(x)).ToList();
        if (alumnus.Count == 0) return [];
        return alumnus;
    }
    public async Task<GetAlumniDto> Post(PostAlumniDto dto, Guid userId)
    {
        var entity = _mapper.MapToEntity(dto);
        var res = await _repo.CreateAlumniProfileAsync(entity, userId);
        return _mapper.MapToGet(res);

    }
    public async Task<GetAlumniDto> Put(PutAlumniDto dto, Guid userId)
    {
        var entity = _mapper.MapToGetFromUpdate(dto);
        var res = await _repo.UpdateAlumniProfileAsync(userId, entity);
        return _mapper.MapToGet(res);
    }
    public async Task<ICollection<GetAlumniDto>> GetAll()
    {
        var entities = await _repo.GetAllAlumni();
        var res = entities.Select(x => _mapper.MapToGet(x)).ToList();
        return res;
    }
}