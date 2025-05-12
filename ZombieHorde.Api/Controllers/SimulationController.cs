using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZombieHorde.Core.UseCases.Simulation.GetTopSimulations;
using ZombieHorde.Core.UseCases.Simulation.RegisterSimulation;
using ZombieHorde.Core.UseCases.Simulation.SimulateHorde;

namespace ZombieHorde.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SimulationController(IMediator mediator) : Controller
    {

        [HttpGet("simulate")]
        [Authorize(Policy = "DefenderPolicy")]
        public async Task<IActionResult> SimulateHorde([FromQuery] SimulateHordeRequest request)
        {
            return Ok(await mediator.Send(request));
        }


        [HttpPost("register-simulation")]
        [Authorize(Policy = "DefenderPolicy")]
        public async Task<IActionResult> RegisterSimulation([FromBody] RegisterSimulationRequest request)
        {
            return Ok(await mediator.Send(request));
        }

        [HttpGet("get-ranking")]
        [AllowAnonymous]
        public async Task<IActionResult> GetTopSimulations([FromQuery] GetTopSimulationsRequest request)
        {
            return Ok(await mediator.Send(request));
        }
    }
}
