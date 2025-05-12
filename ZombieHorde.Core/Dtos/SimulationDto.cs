namespace ZombieHorde.Core.Dtos
{
    public class SimulationDto
    {
        public short TotalScore { get; set; }

        public short AvalibleTime   { get; set; }

        public short AvalibleBullets { get; set; }

        public short RemainingTime { get; set; }

        public short RemainingBullets { get; set; }

        public ICollection<SimulationDetailDto> Details { get; set; }
    }
}
