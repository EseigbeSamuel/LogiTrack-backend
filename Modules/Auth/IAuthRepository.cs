namespace logitrack_api.Modules.Auth;

public interface IAuthRepository
{
    Task<AuthDto> LoginAsync(string email, string password);
    Task<AuthDto> RegisterAsync(string email, string password);
    Task<AuthDto> GetProfileAsync(string userId);
    Task<AuthDto> UpdateProfileAsync(string userId, string name, string email, string phone, string avatar);
    Task<AuthDto> ChangePasswordAsync(string userId, string currentPassword, string newPassword);
    Task<AuthDto> ForgotPasswordAsync(string email);
    Task<AuthDto> ResetPasswordAsync(string userId, string newPassword);
    Task<AuthDto> VerifyEmailAsync(string userId, string token);
    Task<AuthDto> VerifyPhoneAsync(string userId, string token);
    Task<AuthDto> SendVerificationEmailAsync(string userId);
    Task<AuthDto> SendVerificationPhoneAsync(string userId);
}
