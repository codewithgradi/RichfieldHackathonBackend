using DomainTask = RichfieldHackathonBackend.Domain.Models.Task;

public interface ITaskRepo
{
    Task<DomainTask> CreateTaskAsync(DomainTask task, Guid userId);
    Task<ICollection<DomainTask>> GetAllTasks();

}