using System.ComponentModel;
using ModelContextProtocol.Server;
using RichfieldHackathonBackend.Application.Dtos.Alumni;
using RichfieldHackathonBackend.Application.Dtos.Analytics;
using RichfieldHackathonBackend.Application.Dtos.Business;
using RichfieldHackathonBackend.Application.Dtos.Career;
using RichfieldHackathonBackend.Application.Dtos.Certification;
using RichfieldHackathonBackend.Application.Dtos.Student;
using RichfieldHackathonBackend.Application.Dtos.Task;
using RichfieldHackathonBackend.Application.Dtos.TaskSubmission;
using RichfieldHackathonBackend.Application.Services;

[McpServerToolType]
public class AdminMcpTools
{
    private readonly IServiceProvider _serviceProvider;

    public AdminMcpTools(IServiceProvider provider)
    {
        _serviceProvider = provider;
    }
    [McpServerTool(Name = "get_all_registered_alumni"),
     Description("This tool returns a list all registered alumnis in the database from alumi table")]
    public async Task<ICollection<GetAlumniDto>> GetAllRegisteredAlumni()
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<AlumniService>();
        return await service.GetAll();
    }
    [McpServerTool(Name = "get_all_registered_careers"),
     Description("This tool returns a list all registered careers in the database from careers table")]
    public async Task<ICollection<GetCareerDto>> GetAllRegisteredCareers()
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<CareerService>();
        return await service.GetAll();
    }
    [McpServerTool(Name = "get_all_registered_task_submission"),
     Description("This tool returns a list all registered task submissions in the database from task submission table")]
    public async Task<ICollection<GetTaskSubmissionDto>> GetAllRegisteredTaskSubmission()
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<TaskSubService>();
        return await service.GetAll();
    }
    [McpServerTool(Name = "get_all_registered_tasks"),
     Description("This tool returns a list all registered tasks in the database from tasks table")]
    public async Task<ICollection<GetTaskDto>> GetAllRegisteredTasks()
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<TaskService>();
        return await service.GetAll();
    }
    [McpServerTool(Name = "get_all_registered_alumni_engage"),
     Description("This tool returns a list all registered alumni engament in the database from the ananlytics service")]
    public async Task<AlumniEngagementDto> GetAllRegisteredAlumniEngagement()
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<AnalyticsService>();
        return await service.GetAlumniEngagementDtoAsyncSerivice();
    }
    [McpServerTool(Name = "create_task"),
     Description("This tool creates a task by triggering post method from taskservice to create the task")]
    public async Task<GetTaskDto> createTaskByAgent(
        [Description("this is what is required title,Instructions,adminId")] PostTaskDto dto,
        [Description("this is id field from users table")] Guid userId
    )
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<TaskService>();
        return await service.Post(dto, userId);
    }
    [McpServerTool(Name = "get_all_students"),
     Description("this returns all registered students")]
    public async Task<ICollection<GetStudentDto>> GetAllStudents()
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<StudentService>();
        return await service.GetAll();
    }
    [McpServerTool(Name = "get_all_businesses"),
     Description("this returns all registered businesses in businesses table")]
    public async Task<ICollection<GetBusinessDto>> GetAllBusiness()
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<BusinessService>();
        return await service.GetBusinessAll();
    }
    [McpServerTool(Name = "get_all_opportunities"),
     Description("this returns all registered oportunities from oportunities table, do not return image linke")]
    public async Task<ICollection<GetOpportunityDto>> GetAllOpportunities()
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<BusinessService>();
        return await service.GetOpportunityAll();
    }
    [McpServerTool(Name = "create_career"),
     Description("This tool creates a new career by triggering post method from career service to create the carer")]
    public async Task<GetCareerDto> createCareerByAgent(
        [Description("this is what is required title,description,RequiredSkills")] PostCareerDto dto
    )
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<CareerService>();
        return await service.Post(dto);
    }

}