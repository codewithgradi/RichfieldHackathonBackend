using RichfieldHackathonBackend.Application.Dtos.Career;
using RichfieldHackathonBackend.Application.Mappings;
using RichfieldHackathonBackend.Domain.Interfaces;

namespace RichfieldHackathonBackend.Application.Services;

public class CareerService
{
    private readonly ICarrersRepo _repo;
    private readonly CareerMappers _mapper;

    public CareerService(ICarrersRepo repo, CareerMappers mappers)
    {
        _repo = repo;
        _mapper = mappers;
    }
    public async Task<GetCareerDto> Post(PostCareerDto dto)
    {
        var entity = _mapper.MapToEntity(dto);
        var res = await _repo.CreateCareer(entity);
        return _mapper.MapToDto(res);
    }
    public async Task<ICollection<GetCareerDto>> GetAll()
    {

        var certs = await _repo.GetAllCareers();
        var res = certs.Select(x => _mapper.MapToDto(x)).ToList();
        return res;

    }
}