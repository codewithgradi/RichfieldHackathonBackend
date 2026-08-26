using RichfieldHackathonBackend.Application.Analytics.DTOs;
using RichfieldHackathonBackend.Application.Dtos.Analytics;

namespace RichfieldHackathonBackend.Application.Interfaces;
public interface IAnalyticsRepo
{
    Task<AlumniEngagementDto> GetAlumniEngagementDtoAsync();
    Task<TaskSubmissionTrendDto> GetTaskSubmissionTrendAsync();
    Task<DashboardAnalyticsDto> GetDashboardAnalyticsAsync();
}