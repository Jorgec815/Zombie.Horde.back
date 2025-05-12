using MediatR;

namespace ZombieHorde.Core.UseCases.Simulation.GetTopSimulations
{
    public class GetTopSimulationsRequest : IRequest<GetTopSimulationsResponse>
    {
        public int Top { get; set; } = 10;
    }
}
