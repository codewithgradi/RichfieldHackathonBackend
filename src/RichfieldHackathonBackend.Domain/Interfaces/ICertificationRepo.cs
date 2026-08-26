using RichfieldHackathonBackend.Domain.Models;

public interface ICertificationRepo
{
    Task<Certification> CreateCertificationAsync(Certification certification);
    Task<Certification> GetAllCertifications(Guid studentId);

}