using RichfieldHackathonBackend.Domain.Models;

public interface ICertification
{
    Task<Certification> CreateCertificationAsync(Certification certification);
    Task<Certification> GetAllCertifications(Guid studentId);

}