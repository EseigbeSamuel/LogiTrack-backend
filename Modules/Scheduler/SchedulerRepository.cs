namespace logitrack_api.Modules.Scheduler;

public class SchedulerRepository : ISchedulerRepository
{
    public Task<Schedule> CreateScheduleAsync(Schedule schedule)
    {
        throw new NotImplementedException();
    }

    public Task UpdateScheduleAsync(Schedule schedule)
    {
        throw new NotImplementedException();
    }

    public Task<Schedule?> GetScheduleByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Schedule>> GetSchedulesByFleetAsync(Guid fleetId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Schedule>> GetSchedulesByDriverAsync(string driverId)
    {
        throw new NotImplementedException();
    }
}
