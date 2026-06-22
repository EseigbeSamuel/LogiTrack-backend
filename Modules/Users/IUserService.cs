namespace logitrack_api.Modules.Users;

public interface IUserService
{
    Task<UserDto?> GetProfileAsync(string userId);
    Task<UserDto> UpdateProfileAsync(string userId, string name, string email, string phone, string avatar);
    Task<UserDto> ChangePasswordAsync(string userId, string currentPassword, string newPassword);
    Task<UserDto> ForgotPasswordAsync(string email);
    Task<UserDto> ResetPasswordAsync(string userId, string newPassword);
    Task<UserDto> VerifyEmailAsync(string userId, string token);
    Task<UserDto> VerifyPhoneAsync(string userId, string token);
    Task<UserDto> SendVerificationEmailAsync(string userId);
    Task<UserDto> SendVerificationPhoneAsync(string userId);
}
