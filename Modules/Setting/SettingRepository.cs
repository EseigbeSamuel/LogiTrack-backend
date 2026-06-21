namespace logitrack_api.Modules.Setting;

public class SettingRepository : ISettingRepository
{
    public Task<SystemSettingDto> GetSettingByKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SystemSettingDto>> GetAllSettingsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateSettingAsync(string key, string value)
    {
        throw new NotImplementedException();
    }
}
