using logitrack_api.Data;
using Microsoft.EntityFrameworkCore;

namespace logitrack_api.Modules.Fleet;

public class FleetRepository : IFleetRepository
{
    private readonly AppDbContext _context;

    public FleetRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<FleetVehicleDto> CreateVehicleAsync(FleetVehicle vehicle)
    {
        vehicle.CreatedAt = DateTime.UtcNow;
        vehicle.UpdatedAt = DateTime.UtcNow;
        
        _context.FleetVehicles.Add(vehicle);
        await _context.SaveChangesAsync();

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

    public async Task<FleetVehicleDto> UpdateVehicleAsync(FleetVehicle vehicle)
    {
        var existing = await _context.FleetVehicles.FindAsync(vehicle.Id);
        if (existing == null) throw new Exception("Vehicle not found");

        existing.Name = vehicle.Name;
        existing.LicensePlate = vehicle.LicensePlate;
        existing.Type = vehicle.Type;
        existing.Status = vehicle.Status;
        existing.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();

        return new FleetVehicleDto
        {
            Id = existing.Id,
            Name = existing.Name,
            LicensePlate = existing.LicensePlate,
            Type = existing.Type,
            Status = existing.Status,
            CreatedAt = existing.CreatedAt,
            UpdatedAt = existing.UpdatedAt
        };
    }

    public async Task<FleetVehicleDto> GetVehicleByIdAsync(Guid id)
    {
        var vehicle = await _context.FleetVehicles.FindAsync(id);
        if (vehicle == null) return null;

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

    public async Task<IEnumerable<FleetVehicleDto>> GetAllVehiclesAsync()
    {
        return await _context.FleetVehicles
            .Select(v => new FleetVehicleDto
            {
                Id = v.Id,
                Name = v.Name,
                LicensePlate = v.LicensePlate,
                Type = v.Type,
                Status = v.Status,
                CreatedAt = v.CreatedAt,
                UpdatedAt = v.UpdatedAt
            })
            .ToListAsync();
    }

    public async Task<bool> UpdateVehicleStatusAsync(Guid id, string status)
    {
        var vehicle = await _context.FleetVehicles.FindAsync(id);
        if (vehicle == null) return false;

        vehicle.Status = status;
        vehicle.UpdatedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return true;
    }
}
