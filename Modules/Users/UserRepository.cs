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

    public async Task<UserDto> GetProfileAsync(string userId)
    {
        if (!Guid.TryParse(userId, out var parsedId)) return null;

        var user = await _context.Users.FindAsync(parsedId);
        if (user == null) return null;

        return new UserDto
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Avatar = user.Avatar,
            IsActive = user.IsActive,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt
        };
    }
    public async Task<UserDto> UpdateProfileAsync(string userId, string name, string email, string phone, string avatar)
    {
        if (!Guid.TryParse(userId, out var parsedId)) return null;

        var user = await _context.Users.FindAsync(parsedId);
        if (user == null) throw new Exception("User not found");

        user.Name = name;
        user.Email = email;
        user.Avatar = avatar;
        user.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();

        return new UserDto
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Avatar = user.Avatar,
            IsActive = user.IsActive,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt
        };
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
