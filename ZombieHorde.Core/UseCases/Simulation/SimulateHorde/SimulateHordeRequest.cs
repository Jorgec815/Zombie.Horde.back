using MediatR;

namespace ZombieHorde.Core.UseCases.Simulation.SimulateHorde
{
    public class SimulateHordeRequest :IRequest<SimulateHordeResponse>
    {
        public short Bullets { get; set; }

        public short Time { get; set; }
    }
}
