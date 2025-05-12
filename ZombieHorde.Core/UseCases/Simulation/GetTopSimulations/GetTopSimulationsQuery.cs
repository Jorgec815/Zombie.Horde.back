using MediatR;
using ZombieHorde.Core.Contracts;
using ZombieHorde.Core.Dtos;

namespace ZombieHorde.Core.UseCases.Simulation.GetTopSimulations
{
    public class GetTopSimulationsQuery(ISimulationRepository simulationRepository) : IRequestHandler<GetTopSimulationsRequest, GetTopSimulationsResponse>
    {
        public async Task<GetTopSimulationsResponse> Handle(GetTopSimulationsRequest request, CancellationToken cancellationToken)
        {
            var simulations = await simulationRepository.GetTopSimulations(request.Top);

            var response = new GetTopSimulationsResponse
            {
                TopSimulations = simulations.Select(x => new SimulationRankingDto
                {
                    UserName = x.User.Name,
                    TotalScore = x.TotalScore,
                    AvalibleBullets = x.AvalibleBullets,
                    AvalibleTime = x.AvalibleTime,
                    RegisterDate = x.RegisterDate,
                    ZombiesDefeated = (short)x.SimulationDetails.Sum(x => x.ZombiesDefeated),
                    Details = x.SimulationDetails.Select(y => new SimulationDetailDto
                    {
                        Zombie = new ZombieDto
                        {
                            Id = y.Zombie.Id.ToString(),
                            Name = y.Zombie.Name,
                            ThreatLevel = new ZombieLevelDto
                            {
                                Id = y.Zombie.ZombieLevel.Id.ToString(),
                                Description = y.Zombie.ZombieLevel.Description,
                                Level = y.Zombie.ZombieLevel.Level
                            }
                        },
                        Defeated = y.ZombiesDefeated
                    }).ToList()

                }).ToList()
            };

            return response;
        }
    }
}
