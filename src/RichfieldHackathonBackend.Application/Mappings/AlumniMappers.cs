using RichfieldHackathonBackend.Application.Dtos.Alumni;
using RichfieldHackathonBackend.Domain.Models;
using Riok.Mapperly.Abstractions;
namespace RichfieldHackathonBackend.Application.Mappings;
[Mapper]
public partial class AlumniMappers
{
    public partial GetAlumniDto? MapToGet( Alumni alumni);
    public partial Alumni? MapToEntity( PostAlumniDto alumni);
    public partial Alumni MapToGetFromUpdate(PutAlumniDto dto);
    
}