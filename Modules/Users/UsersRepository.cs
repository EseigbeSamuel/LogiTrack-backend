using logitrack_api.Data;

using Microsoft.EntityFrameworkCore;

namespace logitrack_api.Modules.Users;

public class UsersRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UsersRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Users?> GetProfileAsync(Guid userId)
    {
        return await _context.Users.FindAsync(userId);
    }

    public async Task UpdateProfileAsync(Users user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }
    public async Task<IEnumerable<Users>> GetUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task DeleteProfileAsync(Guid userId)
    {
        var user = await _context.Users.FindAsync(userId);
        if (user != null)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
