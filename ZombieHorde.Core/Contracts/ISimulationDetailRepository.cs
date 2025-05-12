using ZombieHorde.Core.Entities;

namespace ZombieHorde.Core.Contracts
{
    public interface ISimulationDetailRepository
    {
        Task<bool> CreateSimulationDetailAsync(SimulationDetailEntity simulationDetail);
    }
}
