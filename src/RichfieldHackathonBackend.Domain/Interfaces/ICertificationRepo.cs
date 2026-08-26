using RichfieldHackathonBackend.Domain.Models;

public interface ICertificationRepo
{
    Task<Certification> CreateCertificationAsync(Certification certification);
    Task<ICollection<Certification>> GetAllCertifications(Guid studentId);

}