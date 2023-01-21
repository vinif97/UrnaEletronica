namespace UrnaEletronica.Domain.Model
{
    public class Election
    {
        public int ElectionId { get; set; }
        public ushort ElectionYear { get; set; }
        public ICollection<ElectionCycle>? ElectionCycles { get; set; }
    }
}
