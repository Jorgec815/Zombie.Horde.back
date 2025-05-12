namespace ZombieHorde.Core.Dtos
{
    public class SimulationRankingDto
    {
        public string UserName { get; set; }
        public short TotalScore { get; set; }

        public short AvalibleTime { get; set; }

        public short AvalibleBullets { get; set; }

        public short ZombiesDefeated { get; set; }

        public DateTime RegisterDate { get; set; }

        public ICollection<SimulationDetailDto> Details { get; set; }
    }
}
