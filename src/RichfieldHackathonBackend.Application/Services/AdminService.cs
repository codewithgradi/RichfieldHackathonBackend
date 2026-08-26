using RichfieldHackathonBackend.Application.Dtos.Admin;
using RichfieldHackathonBackend.Application.Mappings;
using RichfieldHackathonBackend.Domain.Interfaces;

namespace RichfieldHackathonBackend.Application.Services;

public class AdminService
{
    private readonly IAdminRepo _repo;
    private readonly AdminMappers _mapper;

    public AdminService(IAdminRepo adminRepo, AdminMappers mappers)
    {
        _repo = adminRepo;
        _mapper = mappers;
    }
    public async Task<ICollection<GetAdminDto>> Get()
    {
        var enties = await _repo.GetAllAdmins();
        var admins = enties.Select(x => _mapper.MapToGet(x)).ToList();
        if (admins.Count == 0) return [];
        return admins;
    }
    public async Task<GetAdminDto> Post(PostAdminDto dto, Guid userId)
    {
        var entity = _mapper.MapToEntity(dto);
        var res = await _repo.CreateAdminProfileAsync(entity, userId);
        return _mapper.MapToGet(res);

    }
    public async Task<GetAdminDto> Put(PutAdminDto dto, Guid userId)
    {
        var entity = _mapper.MapToEntityFromUpdate(dto);
        var res = await _repo.UpdateAdminProfileAsync(userId, entity);
        return _mapper.MapToGet(res);
    }
    public async Task<ICollection<GetAdminDto>> GetAll()
    {
        var entities = await _repo.GetAllAdmins();
        var res = entities.Select(x => _mapper.MapToGet(x)).ToList();
        return res;
    }
}