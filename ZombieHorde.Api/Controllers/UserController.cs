using MediatR;
using Microsoft.AspNetCore.Mvc;
using ZombieHorde.Core.UseCases.User.ValidateLogin;

namespace ZombieHorde.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(IMediator mediator) : Controller
    {
        [HttpPost("login")]
        public async Task<IActionResult> ValidateLogin([FromBody] ValidateLoginRequest request)
        {

           var response = await mediator.Send(request);

            if (response.User != null)
            {
                return Ok(response);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
