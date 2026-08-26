using RichfieldHackathonBackend.Domain.Models;
using DomainTask = RichfieldHackathonBackend.Domain.Models.Task;

public interface ITaskSubRepo
{
    Task<TaskSubmission> CreateTaskSubAsync(TaskSubmission task, Guid userId);
    Task<ICollection<TaskSubmission>> GetAllTaskSubs();
    Task<ICollection<TaskSubmission>> GetAllTaskSubsByStudentId(Guid studentId);

}