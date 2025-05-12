using ZombieHorde.Core.Dtos;

namespace ZombieHorde.Core.UseCases.Simulation.GetTopSimulations
{
    public class GetTopSimulationsResponse
    {
        public ICollection<SimulationRankingDto> TopSimulations { get; set; }
    }
}
