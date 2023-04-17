namespace UrnaEletronica.Domain.Model
{
    public class Party
    {
        public int PartyId { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }
        public string Description { get; set; }
        public ICollection<Candidate>? Candidates { get; set; }

        public Party(string name, string acronym, string description)
        {
            Name = name;
            Acronym = acronym;
            Description = description;
        }
    }
}
