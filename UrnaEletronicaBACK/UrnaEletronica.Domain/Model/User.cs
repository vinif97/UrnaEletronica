namespace UrnaEletronica.Domain.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? PasswordSalt { get; set; }
        public ushort LoginAttemps { get; set; }
        public Citizen? Citizen { get; set; }
        public Address? Address { get; set; }
    }
}
