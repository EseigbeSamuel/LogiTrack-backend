namespace logitrack_api.Modules.Setting;

public class SettingService : ISettingService
{
    private readonly ISettingRepository _settingRepository;

    public SettingService(ISettingRepository settingRepository)
    {
        _settingRepository = settingRepository;
    }

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
