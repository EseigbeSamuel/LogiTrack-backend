namespace logitrack_api.Modules.Scheduler;

public interface ISchedulerService
{
    Task<ScheduleDto> CreateScheduleAsync(Schedule schedule);
    Task<ScheduleDto> UpdateScheduleAsync(Schedule schedule);
    Task<ScheduleDto> GetScheduleByIdAsync(Guid id);
    Task<IEnumerable<ScheduleDto>> GetSchedulesByFleetAsync(Guid fleetId);
    Task<IEnumerable<ScheduleDto>> GetSchedulesByDriverAsync(string driverId);
}
