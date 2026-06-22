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

    public async Task<FleetVehicle> CreateVehicleAsync(FleetVehicle vehicle)
    {
        _context.FleetVehicles.Add(vehicle);
        await _context.SaveChangesAsync();
        return vehicle;
    }

    public async Task UpdateVehicleAsync(FleetVehicle vehicle)
    {
        _context.FleetVehicles.Update(vehicle);
        await _context.SaveChangesAsync();
    }

    public async Task<FleetVehicle?> GetVehicleByIdAsync(Guid id)
    {
        return await _context.FleetVehicles.FindAsync(id);
    }

    public async Task<IEnumerable<FleetVehicle>> GetAllVehiclesAsync()
    {
        return await _context.FleetVehicles.ToListAsync();
    }
}
