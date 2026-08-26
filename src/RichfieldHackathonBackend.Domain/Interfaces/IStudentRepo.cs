using DomainTask =RichfieldHackathonBackend.Domain.Models.Task;
using RichfieldHackathonBackend.Domain.Models;
namespace RichfieldHackathonBackend.Domain.Interfaces;

public interface IStudentRepo
{
    Task<ICollection<Student>> GetStudents();
    Task<Student> GetStudentProfileAsync(Guid id);
    Task<Student> CreateStudentProfileAsync(Student admin, Guid userId);
    Task<Student> UpdateStudentProfileAsync(Guid id, Student admin);
    Task<TaskSubmission> CreateTaskSubmissionAsync(TaskSubmission task);
    Task<ICollection<TaskSubmission>> GetAllSubmitedTasks(Guid studentId);
    Task<ICollection<DomainTask>> GetAllTasks();
}