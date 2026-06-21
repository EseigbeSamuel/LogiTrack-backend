namespace logitrack_api.Modules.Map;

public class LocationDto
{
    public Guid Id { get; set; }
    public Guid FleetId { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Speed { get; set; }
    public DateTime Timestamp { get; set; }
}
