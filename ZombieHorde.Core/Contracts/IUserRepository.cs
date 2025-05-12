using ZombieHorde.Core.Entities;

namespace ZombieHorde.Persistence.Contracts
{
    public interface IUserRepository
    {

        Task<UserEntity> GetUserByIdAsync(Guid id);

        Task<UserEntity> GetUserByEmailAsync(string email);
    }
}
