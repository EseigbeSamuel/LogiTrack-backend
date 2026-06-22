namespace logitrack_api.Modules.Fleet;

public interface IFleetRepository
{
    Task<FleetVehicle> CreateVehicleAsync(FleetVehicle vehicle);
    Task UpdateVehicleAsync(FleetVehicle vehicle);
    Task<FleetVehicle?> GetVehicleByIdAsync(Guid id);
    Task<IEnumerable<FleetVehicle>> GetAllVehiclesAsync();
}
