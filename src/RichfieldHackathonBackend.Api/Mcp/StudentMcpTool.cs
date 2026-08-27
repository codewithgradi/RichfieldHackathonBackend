using System.ComponentModel;
using ModelContextProtocol.Server;
using RichfieldHackathonBackend.Application.Dtos.Alumni;
using RichfieldHackathonBackend.Application.Dtos.Certification;
using RichfieldHackathonBackend.Application.Dtos.Student;
using RichfieldHackathonBackend.Application.Services;

[McpServerToolType]
public class StudentMcpStudentTool
{
    private readonly IServiceProvider _serviceProvider;

    public StudentMcpStudentTool(IServiceProvider provider)
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
    [McpServerTool(Name = "get_all_registered_alumni"),
     Description("This tool returns a list all registered alumnis in the database from alumi table")]
    public async Task<ICollection<GetAlumniDto>> GetAllRegisteredAlumni()
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<AlumniService>();
        return await service.GetAll();
    }
    [McpServerTool(Name = "get_all_registered_certification"),
     Description("This tool returns a list all registered certification in the database from certification table per student id")]
    public async Task<ICollection<GetCertificationDto>> GetAllRegisteredCerts([Description("This is the student id")] Guid studentId)
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<CertificationService>();
        return await service.GetAll(studentId);
    }
}