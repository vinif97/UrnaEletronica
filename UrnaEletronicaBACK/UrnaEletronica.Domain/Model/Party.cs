namespace UrnaEletronica.Domain.Model
{
    public class Party
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Candidate>? Candidates { get; set; }
    }
}
