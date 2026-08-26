using RichfieldHackathonBackend.Domain.Models;

public interface ICertification
{
    Task<Certification> CreateCertificationAsync();
    Task<Certification> GetAllCertifications(Guid studentId);

}