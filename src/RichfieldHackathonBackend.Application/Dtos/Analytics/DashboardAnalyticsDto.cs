using RichfieldHackathonBackend.Application.Dtos.Analytics;

namespace RichfieldHackathonBackend.Application.Analytics.DTOs;

public class DashboardAnalyticsDto
{
    // High-Level Stat Cards
    public int TotalStudents { get; set; }
    public int TotalAlumni { get; set; }
    public int ActiveMentorships { get; set; }
    public int TotalCertificationsIssued { get; set; }
    public double TaskCompletionRatePercentage { get; set; }

    // Chart Data Arrays
    public List<CareerDistributionDto> TopCareers { get; set; } = new();
    public List<TaskSubmissionTrendDto> SubmissionTrends { get; set; } = new();
    public List<AlumniEngagementDto> TopAlumniContributors { get; set; } = new();
}
