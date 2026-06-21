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
        throw new NotImplementedException();
    }

    public Task<FleetVehicleDto> UpdateVehicleAsync(FleetVehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public Task<FleetVehicleDto> GetVehicleByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<FleetVehicleDto>> GetAllVehiclesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateVehicleStatusAsync(Guid id, string status)
    {
        throw new NotImplementedException();
    }
}
