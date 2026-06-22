namespace logitrack_api.Modules.Scheduler;

public interface ISchedulerRepository
{
    Task<Schedule> CreateScheduleAsync(Schedule schedule);
    Task UpdateScheduleAsync(Schedule schedule);
    Task<Schedule?> GetScheduleByIdAsync(Guid id);
    Task<IEnumerable<Schedule>> GetSchedulesByFleetAsync(Guid fleetId);
    Task<IEnumerable<Schedule>> GetSchedulesByDriverAsync(string driverId);
}
