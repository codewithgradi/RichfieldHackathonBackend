using RichfieldHackathonBackend.Domain.Interfaces;
using RichfieldHackathonBackend.Domain.Models;

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