namespace logitrack_api.Modules.Users;

public interface IUserRepository
{
    Task<IEnumerable<Users>> GetUsersAsync();
    Task<Users?> GetProfileAsync(Guid userId);
    Task UpdateProfileAsync(Users user);
    Task DeleteProfileAsync(Guid userId);
}
