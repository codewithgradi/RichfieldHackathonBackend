using RichfieldHackathonBackend.Domain.Interfaces;
using RichfieldHackathonBackend.Domain.Models;
namespace RichfieldHackathonBackend.Infrastructure.Repo;
public class CareersRepo : ICarrersRepo
{
    public Task<Career> CreateCareer(Career career)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Career>> GetAllCareers()
    {
        throw new NotImplementedException();
    }
}