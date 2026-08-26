using DomainTask = RichfieldHackathonBackend.Domain.Models.Task;

public interface ITaskRepo
{
    Task<DomainTask> CreateTaskAsync(DomainTask task);
    Task<ICollection<DomainTask>> GetAllTasks();

}