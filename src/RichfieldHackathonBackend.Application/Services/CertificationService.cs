using RichfieldHackathonBackend.Application.Dtos.Certification;
using RichfieldHackathonBackend.Application.Mappings;
namespace RichfieldHackathonBackend.Application.Services;

public class CertificationService
{
    private readonly ICertificationRepo _repo;
    private readonly CertificationMappers _mapper;

    public CertificationService(ICertificationRepo repo, CertificationMappers mappers)
    {
        _repo = repo;
        _mapper = mappers;
    }
    public async Task<GetCertificationDto> Post(PostCertificationDto dto)
    {
        var entity = _mapper.MapToEntity(dto);
        var res = await _repo.CreateCertificationAsync(entity);
        return _mapper.MapToDto(res);
    }
    public async Task<ICollection<GetCertificationDto>> GetAll(Guid studentId)
    {

        var certs = await _repo.GetAllCertifications(studentId);
        var res = certs.Select(x => _mapper.MapToDto(x)).ToList();
        return res;

    }
}