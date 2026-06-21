namespace logitrack_api.Modules.Scheduler;

public class ScheduleDto
{
    public Guid Id { get; set; }
    public Guid FleetId { get; set; }
    public string? DriverId { get; set; }
    public string? Origin { get; set; }
    public string? Destination { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string? Status { get; set; }
}
