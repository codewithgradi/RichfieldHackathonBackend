using RichfieldHackathonBackend.Application.Dtos.Career;
using RichfieldHackathonBackend.Domain.Models;
using Riok.Mapperly.Abstractions;
namespace RichfieldHackathonBackend.Application.Mappings;

[Mapper]
public partial class CareerMappers
{
    public partial Career MapToEntity(PostCareerDto dto);
    public partial GetCareerDto MapToDto(Career ent);
}