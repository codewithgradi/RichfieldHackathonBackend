using RichfieldHackathonBackend.Domain.Interfaces;

public class TaskRepo : ITaskRepo
{
    public Task<RichfieldHackathonBackend.Domain.Models.Task> CreateTaskAsync(RichfieldHackathonBackend.Domain.Models.Task task, Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<RichfieldHackathonBackend.Domain.Models.Task>> GetAllTasks()
    {
        throw new NotImplementedException();
    }
}