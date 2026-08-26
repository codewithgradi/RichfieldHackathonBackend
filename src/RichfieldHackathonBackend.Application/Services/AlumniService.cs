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
}