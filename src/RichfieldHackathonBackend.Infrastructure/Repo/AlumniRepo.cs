using RichfieldHackathonBackend.Domain.Interfaces;
using RichfieldHackathonBackend.Domain.Models;
namespace RichfieldHackathonBackend.Infrastructure.Repo;
public class AlumniRepo : IAlumniRepo
{
    public Task<Alumni> CreateAlumniProfileAsync(Alumni alumni, Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Alumni>> GetAllAlumni()
    {
        throw new NotImplementedException();
    }

    public Task<Alumni> GetAlumniProfileAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Alumni> UpdateAlumniProfileAsync(Guid id, Alumni alumni)
    {
        throw new NotImplementedException();
    }
}