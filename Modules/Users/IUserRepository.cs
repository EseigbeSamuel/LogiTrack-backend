namespace logitrack_api.Modules.Users;

public interface IUserRepository
{
    Task<User?> GetProfileAsync(Guid userId);
    Task UpdateProfileAsync(User user);
    Task<User> ChangePasswordAsync(Guid userId, string currentPassword, string newPassword);
    Task<User> ForgotPasswordAsync(string email);
    Task<User> ResetPasswordAsync(Guid userId, string newPassword);
    Task<User> VerifyEmailAsync(Guid userId, string token);
    Task<User> VerifyPhoneAsync(Guid userId, string token);
    Task<User> SendVerificationEmailAsync(Guid userId);
    Task<User> SendVerificationPhoneAsync(Guid userId);
}
