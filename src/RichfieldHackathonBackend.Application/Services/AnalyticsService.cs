using RichfieldHackathonBackend.Application.Analytics.DTOs;
using RichfieldHackathonBackend.Application.Dtos.Analytics;
using RichfieldHackathonBackend.Application.Interfaces;

namespace RichfieldHackathonBackend.Application.Services;
public class AnalyticsService
{
    private readonly IAnalyticsRepo _repo;

    public AnalyticsService(IAnalyticsRepo repo)
    {
        _repo = repo;
    }
    public async Task<AlumniEngagementDto> GetAlumniEngagementDtoAsyncSerivice()
    {
      return await  _repo.GetAlumniEngagementDtoAsync();
    }
    public async Task<TaskSubmissionTrendDto> GetTaskSubmissionTrendAsyncSerivice()
    {
        return await _repo.GetTaskSubmissionTrendAsync();
    }
    public async Task<DashboardAnalyticsDto> GetDashboardAnalyticsAsyncSerivice()
    {
        return await _repo.GetDashboardAnalyticsAsync();
    }
}