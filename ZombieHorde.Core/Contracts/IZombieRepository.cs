using ZombieHorde.Core.Entities;

namespace ZombieHorde.Core.Contracts
{
    public interface IZombieRepository
    {
        Task<IEnumerable<ZombieEntity>> GetAllZombiesAsync();
    }
}
