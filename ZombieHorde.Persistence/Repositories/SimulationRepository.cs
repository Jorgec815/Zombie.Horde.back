using Microsoft.EntityFrameworkCore;
using ZombieHorde.Core.Contracts;
using ZombieHorde.Core.Entities;

namespace ZombieHorde.Persistence.Repositories
{
    public class SimulationRepository : ISimulationRepository
    {
        private readonly ZombieHordeContext _context;
        public SimulationRepository(ZombieHordeContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateSimulationAsync(SimulationEntity simulation)
        {
            _context.Entry(simulation).State = EntityState.Added;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<SimulationEntity> GetSimulationByIdAsync(Guid id)
        {
            return await _context.Simulations
                .Include(s => s.SimulationDetails)
                .ThenInclude(z => z.Zombie)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<ICollection<SimulationEntity>> GetTopSimulations(int top)
        {
            return await _context.Simulations
                .Include(s => s.User)
                .Include(s => s.SimulationDetails)
                .ThenInclude(z => z.Zombie)
                .ThenInclude(z => z.ZombieLevel)
                .OrderByDescending(s => s.TotalScore)
                .Take(top)
                .ToListAsync();
        }
    }
}
