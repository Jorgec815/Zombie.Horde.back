using MediatR;
using ZombieHorde.Core.Dtos;
using ZombieHorde.Core.Helpers;
using ZombieHorde.Persistence.Contracts;

namespace ZombieHorde.Core.UseCases.User.ValidateLogin
{
    public class ValidateLoginCommand : IRequestHandler<ValidateLoginRequest, ValidateLoginResponse>
    {
        private readonly IUserRepository _userRepository;

        public ValidateLoginCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<ValidateLoginResponse> Handle(ValidateLoginRequest request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByEmailAsync(request.Email);

            var pass = PasswordHelper.HashPassword(request.Password);

            if (PasswordHelper.VerifyPassword(user.Password, request.Password))
            {
                return new ValidateLoginResponse
                {
                    User = new UserDto
                    {
                        Id = user.Id.ToString(),
                        Name = user.Name,
                        Email = user.Email,
                        Token = JwtHelper.GenerateToken(user.Email, user.Profile.Description),
                        Profile = new ProfileDto
                        {
                            Id = user.Profile.Id.ToString(),
                            Description = user.Profile.Description
                        }
                    }
                };
            }

            return new ValidateLoginResponse
            {
                User = null,
            };

        }
    }
}
