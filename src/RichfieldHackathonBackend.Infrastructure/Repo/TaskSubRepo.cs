using RichfieldHackathonBackend.Domain.Models;
namespace RichfieldHackathonBackend.Infrastructure.Repo;

public class TaskSubRepo : ITaskSubRepo
{
    public Task<TaskSubmission> CreateTaskSubAsync(TaskSubmission task, Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<TaskSubmission>> GetAllTaskSubs()
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<TaskSubmission>> GetAllTaskSubsByStudentId(Guid studentId)
    {
        throw new NotImplementedException();
    }
}