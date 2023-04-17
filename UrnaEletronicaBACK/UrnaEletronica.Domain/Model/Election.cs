namespace UrnaEletronica.Domain.Model
{
    public class Election
    {
        public int ElectionId { get; set; }
        public ushort ElectionYear { get; set; }
        public ICollection<ElectionCycle>? ElectionCycles { get; set; }

        public Election(ushort electionYear)
        {
            ElectionYear = electionYear;
        }
    }
}
