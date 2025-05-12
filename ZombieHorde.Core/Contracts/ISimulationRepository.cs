using ZombieHorde.Core.Entities;

namespace ZombieHorde.Core.Contracts
{
    public interface ISimulationRepository
    {
        Task<SimulationEntity> GetSimulationByIdAsync(Guid id);

        Task<bool> CreateSimulationAsync(SimulationEntity simulation);

        Task<ICollection<SimulationEntity>> GetTopSimulations(int top);
    }
}
