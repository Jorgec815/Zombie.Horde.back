using Microsoft.EntityFrameworkCore;
using ZombieHorde.Core.Contracts;
using ZombieHorde.Core.Entities;

namespace ZombieHorde.Persistence.Repositories
{
    public class SimulationDetailRepository : ISimulationDetailRepository
    {
        private readonly ZombieHordeContext _context;

        public SimulationDetailRepository(ZombieHordeContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateSimulationDetailAsync(SimulationDetailEntity simulationDetail)
        {
            _context.Entry(simulationDetail).State = EntityState.Added;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
