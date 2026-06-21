namespace logitrack_api.Modules.Fleet;

public class FleetVehicle
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? LicensePlate { get; set; }
    public string? Type { get; set; }
    public string? Status { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
