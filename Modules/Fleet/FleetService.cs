using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace logitrack_api.Modules.Fleet;

public class FleetService : IFleetService
{
    private readonly IFleetRepository _fleetRepository;

    public FleetService(IFleetRepository fleetRepository)
    {
        _fleetRepository = fleetRepository;
    }

    public async Task<FleetVehicleDto> CreateVehicleAsync(FleetVehicle vehicle)
    {
        vehicle.CreatedAt = DateTime.UtcNow;
        vehicle.UpdatedAt = DateTime.UtcNow;

        var created = await _fleetRepository.CreateVehicleAsync(vehicle);

        return MapToDto(created);
    }

    public async Task<FleetVehicleDto> UpdateVehicleAsync(FleetVehicle vehicle)
    {
        var existing = await _fleetRepository.GetVehicleByIdAsync(vehicle.Id);
        if (existing == null) throw new Exception("Vehicle not found");

        existing.Name = vehicle.Name;
        existing.LicensePlate = vehicle.LicensePlate;
        existing.Type = vehicle.Type;
        existing.Status = vehicle.Status;
        existing.UpdatedAt = DateTime.UtcNow;

        await _fleetRepository.UpdateVehicleAsync(existing);

        return MapToDto(existing);
    }

    public async Task<FleetVehicleDto?> GetVehicleByIdAsync(Guid id)
    {
        var vehicle = await _fleetRepository.GetVehicleByIdAsync(id);
        if (vehicle == null) return null;

        return MapToDto(vehicle);
    }

    public async Task<IEnumerable<FleetVehicleDto>> GetAllVehiclesAsync()
    {
        var vehicles = await _fleetRepository.GetAllVehiclesAsync();
        return vehicles.Select(MapToDto);
    }

    public async Task<bool> UpdateVehicleStatusAsync(Guid id, string status)
    {
        var vehicle = await _fleetRepository.GetVehicleByIdAsync(id);
        if (vehicle == null) return false;

        vehicle.Status = status;
        vehicle.UpdatedAt = DateTime.UtcNow;

        await _fleetRepository.UpdateVehicleAsync(vehicle);
        return true;
    }

    private static FleetVehicleDto MapToDto(FleetVehicle vehicle)
    {
        return new FleetVehicleDto
        {
            Id = vehicle.Id,
            Name = vehicle.Name,
            LicensePlate = vehicle.LicensePlate,
            Type = vehicle.Type,
            Status = vehicle.Status,
            CreatedAt = vehicle.CreatedAt,
            UpdatedAt = vehicle.UpdatedAt
        };
    }
}
