using Microsoft.EntityFrameworkCore;
using ZombieHorde.Core.Entities;
using ZombieHorde.Persistence.Contracts;

namespace ZombieHorde.Persistence.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly ZombieHordeContext _context;
        public UserRepository(ZombieHordeContext context)
        {
            _context = context;
        }
        public async Task<UserEntity> GetUserByIdAsync(Guid id)
        {
            return await _context.Users
                .Include(u => u.Profile)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<UserEntity> GetUserByEmailAsync(string email)
        {

            var user = await _context.Users
                .Include(u => u.Profile)
                .FirstOrDefaultAsync(u => u.Email == email);
            return user;
        }
    }
}
