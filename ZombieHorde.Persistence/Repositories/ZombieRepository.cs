using Microsoft.EntityFrameworkCore;
using ZombieHorde.Core.Contracts;
using ZombieHorde.Core.Entities;

namespace ZombieHorde.Persistence.Repositories
{
    public class ZombieRepository: IZombieRepository
    {
        private readonly ZombieHordeContext _context;

        public ZombieRepository(ZombieHordeContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ZombieEntity>> GetAllZombiesAsync()
        {
            return await _context.Zombies
                .Include(z => z.ZombieLevel)
                .ToListAsync();   
        }
    }
}
