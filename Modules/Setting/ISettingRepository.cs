namespace logitrack_api.Modules.Setting;

public interface ISettingRepository
{
    Task<SystemSettingDto> GetSettingByKeyAsync(string key);
    Task<IEnumerable<SystemSettingDto>> GetAllSettingsAsync();
    Task<bool> UpdateSettingAsync(string key, string value);
}
