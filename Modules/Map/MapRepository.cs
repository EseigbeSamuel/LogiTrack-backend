namespace logitrack_api.Modules.Map;

public class MapRepository : IMapRepository
{
    public Task<Location> UpdateFleetLocationAsync(Location location)
    {
        throw new NotImplementedException();
    }

    public Task<Location?> GetFleetLocationAsync(Guid fleetId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Location>> GetFleetRouteHistoryAsync(Guid fleetId, DateTime startTime, DateTime endTime)
    {
        throw new NotImplementedException();
    }
}
