using UrnaEletronica.Domain.Enum;

namespace UrnaEletronica.Domain.Model
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string? FullName { get; set; }
        public PoliticalRole PoliticalRole { get; set; }
        public int ElectionCycleId { get; set; }
        public ElectionCycle? ElectionCycle { get; set; }
        public int PartyId { get; set; }
        public Party? Party { get; set; }
    }
}
