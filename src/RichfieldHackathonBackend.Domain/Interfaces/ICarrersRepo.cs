namespace RichfieldHackathonBackend.Domain.Interfaces;
using RichfieldHackathonBackend.Domain.Models;

public interface ICarrersRepo
{
    Task<ICollection<Career>> GetAllCareers();
    Task<Career> CreateCareer(Career career);

}