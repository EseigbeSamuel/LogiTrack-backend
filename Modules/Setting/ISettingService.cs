namespace logitrack_api.Modules.Setting;

public interface ISettingService
{
    Task<SystemSettingDto> GetSettingByKeyAsync(string key);
    Task<IEnumerable<SystemSettingDto>> GetAllSettingsAsync();
    Task<bool> UpdateSettingAsync(string key, string value);
}
