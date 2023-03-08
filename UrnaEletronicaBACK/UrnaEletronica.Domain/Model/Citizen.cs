namespace UrnaEletronica.Domain.Model
{
    public class Citizen
    {
        public int CitizenId { get; set; }
        public string? CPF { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }

        public void CleanCPF()
        {
            if (CPF != null)
                CPF = CPF.Trim().Replace("-", "").Replace(".", "");
        }
    }
}
