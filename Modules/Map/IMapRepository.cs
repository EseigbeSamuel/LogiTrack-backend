namespace logitrack_api.Modules.Map;

public interface IMapRepository
{
    Task<LocationDto> UpdateFleetLocationAsync(Guid fleetId, double lat, double lng, double speed);
    Task<LocationDto> GetFleetLocationAsync(Guid fleetId);
    Task<IEnumerable<LocationDto>> GetFleetRouteHistoryAsync(Guid fleetId, DateTime startTime, DateTime endTime);
}
