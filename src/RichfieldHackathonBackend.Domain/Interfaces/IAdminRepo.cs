using RichfieldHackathonBackend.Domain.Models;
using DomainTask = RichfieldHackathonBackend.Domain.Models.Task;
namespace RichfieldHackathonBackend.Domain.Interfaces;

public interface IAdminRepo
{
    Task<Admin> GetAdminProfileAsync(Guid id);
    Task<Admin> CreateAdminProfileAsync(Admin admin, Guid userId);
    Task<Admin> UpdateAdminProfileAsync(Guid id, Admin admin);
    Task<DomainTask> CreateTaskAsync(DomainTask task);
    Task<ICollection<DomainTask>> GetAllSuggestions();
    Task<ICollection<DomainTask>> GetAllTasks();
    Task<ICollection<Student>> GetAllStudents();
    Task<ICollection<Admin>> GetAllAdmins();
    Task<ICollection<Alumni>> GetAllAlumni();
    Task<ICollection<TaskSubmission>> GetAllSubmissions();
}