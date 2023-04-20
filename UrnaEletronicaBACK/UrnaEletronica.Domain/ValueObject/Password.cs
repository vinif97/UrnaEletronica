namespace UrnaEletronica.Domain.ValueObject
{
    public class Password
    {
        public string PasswordString { get; set; }
        public string ConfirmPassword { get; set; }
        public byte[]? PasswordSalt { get; private set; }

#pragma warning disable CS8618 // EF constructor
        private Password() { }
#pragma warning restore CS8618 // EF constructor
        public Password(string password, string confirmPassword)
        {
            PasswordString = password;
            ConfirmPassword = confirmPassword;
        }
        public Password(string password, string confirmPassword, byte[] passwordSalt)
        {
            PasswordString = password;
            ConfirmPassword = confirmPassword;
            PasswordSalt = passwordSalt;
        }

        public void SetPasswordSalt(byte[] salt)
        {
            PasswordSalt = salt;
        }
    }
}
