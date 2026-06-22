namespace logitrack_api.Modules.Setting;

public interface ISettingRepository
{
    Task<SystemSetting?> GetSettingByKeyAsync(string key);
    Task<IEnumerable<SystemSetting>> GetAllSettingsAsync();
    Task UpdateSettingAsync(SystemSetting setting);
}
