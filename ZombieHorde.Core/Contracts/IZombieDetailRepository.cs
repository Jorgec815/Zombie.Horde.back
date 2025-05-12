using ZombieHorde.Core.Entities;

namespace ZombieHorde.Core.Contracts
{
    public interface IZombieDetailRepository
    {
        Task<IEnumerable<SimulationDetailEntity>> GetZombieDetailsBySimulationIdAsync(Guid simulationId);

        Task<bool> CreateZombieDetailAsync(SimulationDetailEntity simulationDetail);


    }
}
