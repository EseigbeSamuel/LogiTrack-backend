namespace logitrack_api.Modules.Map;

public interface IMapRepository
{
    Task<Location> UpdateFleetLocationAsync(Location location);
    Task<Location?> GetFleetLocationAsync(Guid fleetId);
    Task<IEnumerable<Location>> GetFleetRouteHistoryAsync(Guid fleetId, DateTime startTime, DateTime endTime);
}
