using logitrack_api.Data;
using Microsoft.EntityFrameworkCore;

namespace logitrack_api.Modules.Users;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetProfileAsync(Guid userId)
    {
        return await _context.Users.FindAsync(userId);
    }

    public async Task UpdateProfileAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public Task<User> ChangePasswordAsync(Guid userId, string currentPassword, string newPassword)
    {
        throw new NotImplementedException();
    }

    public Task<User> ForgotPasswordAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<User> ResetPasswordAsync(Guid userId, string newPassword)
    {
        throw new NotImplementedException();
    }

    public Task<User> VerifyEmailAsync(Guid userId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<User> VerifyPhoneAsync(Guid userId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<User> SendVerificationEmailAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<User> SendVerificationPhoneAsync(Guid userId)
    {
        throw new NotImplementedException();
    }
}
