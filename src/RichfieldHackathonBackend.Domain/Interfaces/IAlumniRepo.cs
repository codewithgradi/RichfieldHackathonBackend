using DomainTask = RichfieldHackathonBackend.Domain.Models.Task;
namespace RichfieldHackathonBackend.Domain.Interfaces;
using RichfieldHackathonBackend.Domain.Models;
public interface IAlumniRepo
{
    Task<ICollection<Student>> GetStudents();
    Task<Alumni> GetAlumniProfileAsync(Guid id);
    Task<Alumni> CreateAlumniProfileAsync(Alumni alumni, Guid userId);
    Task<Alumni> UpdateAlumniProfileAsync(Guid id, Alumni alumni);
    Task<DomainTask> CreateTaskSuggestionnAsync();

}