namespace logitrack_api.Modules.Fleet;

public interface IFleetService
{
    Task<FleetVehicleDto> CreateVehicleAsync(FleetVehicle vehicle);
    Task<FleetVehicleDto> UpdateVehicleAsync(FleetVehicle vehicle);
    Task<FleetVehicleDto?> GetVehicleByIdAsync(Guid id);
    Task<IEnumerable<FleetVehicleDto>> GetAllVehiclesAsync();
    Task<bool> UpdateVehicleStatusAsync(Guid id, string status);
}
