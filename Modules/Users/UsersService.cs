using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace logitrack_api.Modules.Users;

public class UsersService : IUsersService
{
    private readonly IUserRepository _userRepository;

    public UsersService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UsersDto?> GetProfileAsync(string userId)
    {
        if (!Guid.TryParse(userId, out var parsedId)) return null;

        var user = await _userRepository.GetProfileAsync(parsedId);
        if (user == null) return null;

        return new UsersDto
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

    public async Task<UsersDto> UpdateProfileAsync(string userId, string name, string email, string phone, string avatar)
    {
        if (!Guid.TryParse(userId, out var parsedId)) throw new ArgumentException("Invalid user ID format");

        var user = await _userRepository.GetProfileAsync(parsedId);
        if (user == null) throw new Exception("User not found");

        user.Name = name;
        user.Email = email;
        user.Avatar = avatar;
        user.UpdatedAt = DateTime.UtcNow;

        await _userRepository.UpdateProfileAsync(user);

        return new UsersDto
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

    public async Task<IEnumerable<UsersDto>> GetUsersAsync()
    {
        var users = await _userRepository.GetUsersAsync();
        return users.Select(user => new UsersDto
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Avatar = user.Avatar,
            IsActive = user.IsActive,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt
        });
    }

    public async Task DeleteProfileAsync(string userId)
    {
        if (!Guid.TryParse(userId, out var parsedId)) throw new ArgumentException("Invalid user ID format");
        await _userRepository.DeleteProfileAsync(parsedId);
    }

}
