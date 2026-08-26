using RichfieldHackathonBackend.Application.Dtos.Certification;
using RichfieldHackathonBackend.Domain.Models;
using Riok.Mapperly.Abstractions;
namespace RichfieldHackathonBackend.Application.Mappings;

[Mapper]
public partial class CertificationMappers
{
    public partial Certification MapToEntity(PostCertificationDto dto);
    public partial GetCertificationDto MapToDto(Certification ent);
}