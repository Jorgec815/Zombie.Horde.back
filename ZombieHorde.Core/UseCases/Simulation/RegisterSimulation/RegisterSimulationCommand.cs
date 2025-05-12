using MediatR;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using ZombieHorde.Core.Contracts;
using ZombieHorde.Core.Entities;

namespace ZombieHorde.Core.UseCases.Simulation.RegisterSimulation
{
    public class RegisterSimulationCommand(ISimulationRepository simulationRepository, ISimulationDetailRepository simulationDetailRepository, IHttpContextAccessor httpContextAccessor) : IRequestHandler<RegisterSimulationRequest, RegisterSimulationResponse>
    {
        private readonly ISimulationRepository _simulationRepository = simulationRepository;
        private readonly ISimulationDetailRepository _simulationDetailRepository = simulationDetailRepository;
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
        public async Task<RegisterSimulationResponse> Handle(RegisterSimulationRequest request, CancellationToken cancellationToken)
        {
            var email = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.Email)?.Value;
            var simulation = new SimulationEntity
            {
                Id = Guid.NewGuid(),
                UserId = Guid.Parse(request.UserId),
                TotalScore = request.TotalScore,
                AvalibleTime = request.AvalibleTime,
                AvalibleBullets = request.AvalibleBullets,
                RegisterBy = email,
                RegisterDate = DateTime.UtcNow,
            };

            var success = await _simulationRepository.CreateSimulationAsync(simulation);

            if (!success)
            {
                return new RegisterSimulationResponse
                {
                    Success = false,
                };
            }


            foreach (var detail in request.Details)
            {
                var simulationDetail = new SimulationDetailEntity
                {
                    Id = Guid.NewGuid(),
                    SimulationId = simulation.Id,
                    ZombieId = Guid.Parse(detail.Zombie.Id),
                    ZombiesDefeated = detail.Defeated,
                    RegisterBy = email,
                    RegisterDate = DateTime.UtcNow,
                };
                var successDetail = await _simulationDetailRepository.CreateSimulationDetailAsync(simulationDetail);
                if (!successDetail)
                {
                    return new RegisterSimulationResponse
                    {
                        Success = false,
                    };
                }
            }
            return new RegisterSimulationResponse
            {
                Success = true,
            };
        }
    }
}
