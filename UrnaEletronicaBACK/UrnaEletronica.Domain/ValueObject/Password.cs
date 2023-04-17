namespace UrnaEletronica.Domain.ValueObject
{
    public class Password
    {
        public string PasswordString { get; set; }
        public string? ConfirmPassword { get; set; }
        public byte[]? PasswordSalt { get; set; }

        public Password(string password)
        {
            PasswordString = password;
        }
    }
}
