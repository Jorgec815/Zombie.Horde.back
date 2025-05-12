using MediatR;

namespace ZombieHorde.Core.UseCases.User.ValidateLogin
{
    public class ValidateLoginRequest: IRequest<ValidateLoginResponse>
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
