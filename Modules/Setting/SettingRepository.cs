namespace logitrack_api.Modules.Setting;

public class SettingRepository : ISettingRepository
{
    public Task<SystemSetting?> GetSettingByKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SystemSetting>> GetAllSettingsAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateSettingAsync(SystemSetting setting)
    {
        throw new NotImplementedException();
    }
}
