using RichfieldHackathonBackend.Domain.Models;
namespace RichfieldHackathonBackend.Infrastructure.Repo;

public class CertRepo : ICertificationRepo
{
    public Task<Certification> CreateCertificationAsync(Certification certification)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Certification>> GetAllCertifications(Guid studentId)
    {
        throw new NotImplementedException();
    }
}