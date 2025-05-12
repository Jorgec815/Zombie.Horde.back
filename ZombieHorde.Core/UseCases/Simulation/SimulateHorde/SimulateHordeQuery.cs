using MediatR;
using ZombieHorde.Core.Contracts;
using ZombieHorde.Core.Dtos;

namespace ZombieHorde.Core.UseCases.Simulation.SimulateHorde
{
    public class SimulateHordeQuery(IZombieRepository zombieRepository) : IRequestHandler<SimulateHordeRequest, SimulateHordeResponse>
    {
        private readonly IZombieRepository _zombieRepository = zombieRepository;
        public async Task<SimulateHordeResponse> Handle(SimulateHordeRequest request, CancellationToken cancellationToken)
        {
            var zombies = await _zombieRepository.GetAllZombiesAsync();
            
            var AvalibleBullets = request.Bullets;

            var AvalibleTime = request.Time;

            List<SimulationDetailDto> simulationDetails = new List<SimulationDetailDto>();

            short totalScore = 0;

            zombies = zombies.OrderByDescending(z => z.Score / (z.NeccesaryBullets + z.TimeNeeded)).ToList(); ; //Ordenarlos zombies por un coeficiente de eficiencia

            foreach(var zombie in zombies)
            {
                short defeated = 0;
                while(zombie.NeccesaryBullets <= AvalibleBullets && zombie.TimeNeeded <= AvalibleTime)
                {
                    defeated ++;
                    AvalibleBullets -= zombie.NeccesaryBullets;
                    AvalibleTime -= zombie.TimeNeeded;
                    totalScore += zombie.Score;
                }
                if(defeated > 0)
                {
                    simulationDetails.Add(new SimulationDetailDto
                    {
                        Zombie = new ZombieDto
                        {
                            Id = zombie.Id.ToString(),
                            Name = zombie.Name,
                            ThreatLevel = new ZombieLevelDto
                            {
                                Id = zombie.ZombieLevel.Id.ToString(),
                                Description = zombie.ZombieLevel.Description,
                                Level = zombie.ZombieLevel.Level
                            }
                        },
                        Defeated = defeated
                    });
                }
            }
            return new SimulateHordeResponse
            {
                Simulation = new SimulationDto
                {
                    AvalibleBullets = request.Bullets,
                    AvalibleTime = request.Time,
                    Details = simulationDetails,
                    RemainingBullets = AvalibleBullets,
                    RemainingTime = AvalibleTime,
                    TotalScore = totalScore
                }
            };
        }
    }
}
