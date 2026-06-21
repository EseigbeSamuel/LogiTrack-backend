namespace logitrack_api.Modules.Scheduler;

public class SchedulerRepository : ISchedulerRepository
{
    public Task<ScheduleDto> CreateScheduleAsync(Schedule schedule)
    {
        throw new NotImplementedException();
    }

    public Task<ScheduleDto> UpdateScheduleAsync(Schedule schedule)
    {
        throw new NotImplementedException();
    }

    public Task<ScheduleDto> GetScheduleByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ScheduleDto>> GetSchedulesByFleetAsync(Guid fleetId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ScheduleDto>> GetSchedulesByDriverAsync(string driverId)
    {
        throw new NotImplementedException();
    }
}
