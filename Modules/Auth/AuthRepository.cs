namespace logitrack_api.Modules.Auth;

public class AuthRepository : IAuthRepository
{
    public Task<AuthDto> LoginAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<AuthDto> RegisterAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<AuthDto> GetProfileAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<AuthDto> UpdateProfileAsync(string userId, string name, string email, string phone, string avatar)
    {
        throw new NotImplementedException();
    }

    public Task<AuthDto> ChangePasswordAsync(string userId, string currentPassword, string newPassword)
    {
        throw new NotImplementedException();
    }

    public Task<AuthDto> ForgotPasswordAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<AuthDto> ResetPasswordAsync(string userId, string newPassword)
    {
        throw new NotImplementedException();
    }

    public Task<AuthDto> VerifyEmailAsync(string userId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<AuthDto> VerifyPhoneAsync(string userId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<AuthDto> SendVerificationEmailAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<AuthDto> SendVerificationPhoneAsync(string userId)
    {
        throw new NotImplementedException();
    }
}
