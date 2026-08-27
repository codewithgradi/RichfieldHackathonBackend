using System.ComponentModel;
using ModelContextProtocol.Server;
using RichfieldHackathonBackend.Application.Dtos.Student;
using RichfieldHackathonBackend.Application.Services;

[McpServerToolType]
public class AluminiMcpTool
{
    private readonly IServiceProvider _serviceProvider;

    public AluminiMcpTool(IServiceProvider provider)
    {
        _serviceProvider = provider;
    }
    [McpServerTool(Name = "get_all_students"),
     Description("this returns all registered students")]
    public async Task<ICollection<GetStudentDto>> GetAllStudents()
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<StudentService>();
        return await service.GetAll();
    }
}