namespace RichfieldHackathonBackend.Application.Dtos.Analytics;

public class AlumniEngagementDto
{
    public Guid AlumniId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;

    // Impact Metrics
    public int ActiveMenteesCount { get; set; }
    public int TasksSuggestedCount { get; set; }
    public int TasksApprovedCount { get; set; }
}