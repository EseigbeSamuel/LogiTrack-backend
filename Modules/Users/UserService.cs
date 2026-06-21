namespace logitrack_api.Modules.Users;

public class UserService
{
    public Task<UserDto> GetProfileAsync(string userId)
    {
        throw new NotImplementedException();
    }
    public Task<UserDto> UpdateProfileAsync(string userId, string name, string email, string phone, string avatar)
    {
        throw new NotImplementedException();
    }
    public Task<UserDto> ChangePasswordAsync(string userId, string currentPassword, string newPassword)
    {
        throw new NotImplementedException();
    }
    public Task<UserDto> ForgotPasswordAsync(string email)
    {
        throw new NotImplementedException();
    }
    public Task<UserDto> ResetPasswordAsync(string userId, string newPassword)
    {
        throw new NotImplementedException();
    }
    public Task<UserDto> VerifyEmailAsync(string userId, string token)
    {
        throw new NotImplementedException();
    }
    public Task<UserDto> VerifyPhoneAsync(string userId, string token)
    {
        throw new NotImplementedException();
    }
    public Task<UserDto> SendVerificationEmailAsync(string userId)
    {
        throw new NotImplementedException();
    }
    public Task<UserDto> SendVerificationPhoneAsync(string userId)
    {
        throw new NotImplementedException();
    }
}
