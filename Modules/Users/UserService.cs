namespace logitrack_api.Modules.Users;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<UserDto> GetProfileAsync(string userId)
    {
        return _userRepository.GetProfileAsync(userId);
    }
    public Task<UserDto> UpdateProfileAsync(string userId, string name, string email, string phone, string avatar)
    {
        return _userRepository.UpdateProfileAsync(userId, name, email, phone, avatar);
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
