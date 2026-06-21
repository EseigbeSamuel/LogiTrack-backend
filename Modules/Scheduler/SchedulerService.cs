namespace logitrack_api.Modules.Scheduler;

public class SchedulerService : ISchedulerService
{
    private readonly ISchedulerRepository _schedulerRepository;

    public SchedulerService(ISchedulerRepository schedulerRepository)
    {
        _schedulerRepository = schedulerRepository;
    }

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
