using RichfieldHackathonBackend.Domain.Interfaces;
using RichfieldHackathonBackend.Domain.Models;

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