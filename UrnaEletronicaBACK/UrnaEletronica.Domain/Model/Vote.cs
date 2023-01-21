namespace UrnaEletronica.Domain.Model
{
    public class Vote
    {
        public int VoteId { get; set; }
        public DateTime VoteTime { get; set; }
        public Citizen? Citizen { get; set; }
        public int CandidateId { get; set; }
        public Candidate? Candidate { get; set; }
        public int ElectionCycleId { get; set; }
        public ElectionCycle? Election { get; set; }
    }
}
