namespace RichfieldHackathonBackend.Infrastructure.Repo;

using DomainTask = Domain.Models.Task;
public class TaskRepo : ITaskRepo
{
    public Task<DomainTask> CreateTaskAsync(DomainTask task, Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<DomainTask>> GetAllTasks()
    {
        throw new NotImplementedException();
    }
}