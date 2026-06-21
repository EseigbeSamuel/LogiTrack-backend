namespace logitrack_api.Modules.Map;

public class MapRepository : IMapRepository
{
    public Task<LocationDto> UpdateFleetLocationAsync(Guid fleetId, double lat, double lng, double speed)
    {
        throw new NotImplementedException();
    }

    public Task<LocationDto> GetFleetLocationAsync(Guid fleetId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<LocationDto>> GetFleetRouteHistoryAsync(Guid fleetId, DateTime startTime, DateTime endTime)
    {
        throw new NotImplementedException();
    }
}
