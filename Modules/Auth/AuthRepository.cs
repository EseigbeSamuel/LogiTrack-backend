namespace logitrack_api.Modules.Auth;

public class AuthRepository : IAuthRepository
{
    public Task<Auth?> LoginAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<Auth> RegisterAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<Auth?> GetProfileAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateProfileAsync(Auth auth)
    {
        throw new NotImplementedException();
    }

    public Task<Auth> ChangePasswordAsync(Guid userId, string currentPassword, string newPassword)
    {
        throw new NotImplementedException();
    }

    public Task<Auth> ForgotPasswordAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<Auth> ResetPasswordAsync(Guid userId, string newPassword)
    {
        throw new NotImplementedException();
    }

    public Task<Auth> VerifyEmailAsync(Guid userId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<Auth> VerifyPhoneAsync(Guid userId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<Auth> SendVerificationEmailAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<Auth> SendVerificationPhoneAsync(Guid userId)
    {
        throw new NotImplementedException();
    }
}
