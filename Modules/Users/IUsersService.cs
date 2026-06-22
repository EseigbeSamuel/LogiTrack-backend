namespace logitrack_api.Modules.Users;

public interface IUsersService
{
    Task<IEnumerable<UsersDto>> GetUsersAsync();
    Task<UsersDto?> GetProfileAsync(string userId);
    Task<UsersDto> UpdateProfileAsync(string userId, string name, string email, string phone, string avatar);
    Task DeleteProfileAsync(string userId);
}
