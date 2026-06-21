namespace logitrack_api.Modules.Setting;

public class SystemSettingDto
{
    public Guid Id { get; set; }
    public string? Key { get; set; }
    public string? Value { get; set; }
    public string? Description { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
