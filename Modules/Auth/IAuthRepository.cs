namespace logitrack_api.Modules.Auth;

public interface IAuthRepository
{
    Task<Auth?> LoginAsync(string email, string password);
    Task<Auth> RegisterAsync(string email, string password);
    Task<Auth?> GetProfileAsync(Guid userId);
    Task UpdateProfileAsync(Auth auth);
    Task<Auth> ChangePasswordAsync(Guid userId, string currentPassword, string newPassword);
    Task<Auth> ForgotPasswordAsync(string email);
    Task<Auth> ResetPasswordAsync(Guid userId, string newPassword);
    Task<Auth> VerifyEmailAsync(Guid userId, string token);
    Task<Auth> VerifyPhoneAsync(Guid userId, string token);
    Task<Auth> SendVerificationEmailAsync(Guid userId);
    Task<Auth> SendVerificationPhoneAsync(Guid userId);
}
