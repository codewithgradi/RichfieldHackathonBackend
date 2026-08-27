using RichfieldHackathonBackend.Domain.Interfaces;
using RichfieldHackathonBackend.Domain.Models;
namespace RichfieldHackathonBackend.Infrastructure.Repo;
public class AdminRepo : IAdminRepo
{
    public Task<Admin> CreateAdminProfileAsync(Admin admin, Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<Admin> GetAdminProfileAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Admin>> GetAllAdmins()
    {
        throw new NotImplementedException();
    }

    public Task<Admin> UpdateAdminProfileAsync(Guid id, Admin admin)
    {
        throw new NotImplementedException();
    }
}