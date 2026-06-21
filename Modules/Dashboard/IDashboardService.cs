namespace logitrack_api.Modules.Dashboard;

public interface IDashboardService
{
    Task<DashboardDto> GetSummaryStatisticsAsync();
    Task<IEnumerable<object>> GetRecentActivityAsync();
}
