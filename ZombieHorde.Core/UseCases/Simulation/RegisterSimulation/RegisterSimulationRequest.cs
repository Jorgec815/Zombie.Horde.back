using MediatR;
using ZombieHorde.Core.Dtos;

namespace ZombieHorde.Core.UseCases.Simulation.RegisterSimulation
{
    public class RegisterSimulationRequest: IRequest<RegisterSimulationResponse>
    {
        public string UserId { get; set; }

        public short TotalScore { get; set; }

        public short AvalibleTime { get; set; }

        public short AvalibleBullets { get; set; }

        public ICollection<SimulationDetailDto> Details { get; set; }
    }
}
