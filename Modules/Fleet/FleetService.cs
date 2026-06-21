namespace logitrack_api.Modules.Fleet;

public class FleetService : IFleetService
{
    private readonly IFleetRepository _fleetRepository;

    public FleetService(IFleetRepository fleetRepository)
    {
        _fleetRepository = fleetRepository;
    }

    public Task<FleetVehicleDto> CreateVehicleAsync(FleetVehicle vehicle)
    {
        return _fleetRepository.CreateVehicleAsync(vehicle);
    }

    public Task<FleetVehicleDto> UpdateVehicleAsync(FleetVehicle vehicle)
    {
        return _fleetRepository.UpdateVehicleAsync(vehicle);
    }

    public Task<FleetVehicleDto> GetVehicleByIdAsync(Guid id)
    {
        return _fleetRepository.GetVehicleByIdAsync(id);
    }

    public Task<IEnumerable<FleetVehicleDto>> GetAllVehiclesAsync()
    {
        return _fleetRepository.GetAllVehiclesAsync();
    }

    public Task<bool> UpdateVehicleStatusAsync(Guid id, string status)
    {
        return _fleetRepository.UpdateVehicleStatusAsync(id, status);
    }
}
