using RichfieldHackathonBackend.Domain.Models;
namespace RichfieldHackathonBackend.Domain.Interfaces;

public interface IAdminRepo
{
    Task<Admin> GetAdminProfileAsync(Guid id);
    Task<Admin> CreateAdminProfileAsync(Admin admin, Guid userId);
    Task<Admin> UpdateAdminProfileAsync(Guid id, Admin admin);
    Task<ICollection<Admin>> GetAllAdmins();
}