namespace logitrack_api.Modules.Fleet;

public class FleetRepository : IFleetRepository
{
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
