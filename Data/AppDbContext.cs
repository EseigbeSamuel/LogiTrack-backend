using logitrack_api.Modules.Chat;
using logitrack_api.Modules.Fleet;
using logitrack_api.Modules.Map;
using logitrack_api.Modules.Notification;
using logitrack_api.Modules.Scheduler;
using logitrack_api.Modules.Setting;
using logitrack_api.Modules.Users;

using Microsoft.EntityFrameworkCore;

namespace logitrack_api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Users> Users { get; set; }
    public DbSet<ChatMessage> ChatMessages { get; set; }
    public DbSet<FleetVehicle> FleetVehicles { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<SystemSetting> SystemSettings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
