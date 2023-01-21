using UrnaEletronica.Domain.Enum;

namespace UrnaEletronica.Domain.Model
{
    public class ElectionCycle
    {
        public int ElectionCycleId { get; set; }
        public int ElectionId { get; set; }
        public Election? Election { get; set; }
        public PoliticalRole PoliticalRole { get; set; }
        public ICollection<Candidate>? Candidates { get; set; }
        public ICollection<Vote>? Votes { get; set; }
    }
}