using Microsoft.Extensions.AI;

public class McpToolsRegistery
{
    private readonly AdminMcpTools _adminTools;
    private readonly StudentMcpStudentTool _studentTools;
    private readonly AluminiMcpTool _alumniTools;
    private List<AITool> _tools = new ();
    public McpToolsRegistery(AdminMcpTools adminMcpTools, StudentMcpStudentTool studentMcpStudent,AluminiMcpTool aluminiMcpTool)
    {
        _tools.AddRange(AIFunctionFactory.Create(studentMcpStudent.GetAllRegisteredAlumni));
        _tools.AddRange(AIFunctionFactory.Create(studentMcpStudent.GetAllRegisteredCerts));
        _tools.AddRange(AIFunctionFactory.Create(studentMcpStudent.GetAllStudents));
        _tools.AddRange(AIFunctionFactory.Create(aluminiMcpTool.GetAllStudents));

        _tools.AddRange(AIFunctionFactory.Create(adminMcpTools.createCareerByAgent));
        _tools.AddRange(AIFunctionFactory.Create(adminMcpTools.createTaskByAgent));
        _tools.AddRange(AIFunctionFactory.Create(adminMcpTools.GetAllBusiness));
        _tools.AddRange(AIFunctionFactory.Create(adminMcpTools.GetAllOpportunities));
        _tools.AddRange(AIFunctionFactory.Create(adminMcpTools.GetAllRegisteredAlumni));
        _tools.AddRange(AIFunctionFactory.Create(adminMcpTools.GetAllRegisteredAlumniEngagement));
        _tools.AddRange(AIFunctionFactory.Create(adminMcpTools.GetAllRegisteredCareers));
        _tools.AddRange(AIFunctionFactory.Create(adminMcpTools.GetAllRegisteredTasks));
        _tools.AddRange(AIFunctionFactory.Create(adminMcpTools.GetAllStudents));

    }
    public List<AITool> GetAITools()=> _tools;
}