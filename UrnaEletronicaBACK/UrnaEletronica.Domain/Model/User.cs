using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Domain.ValueObject;

namespace UrnaEletronica.Domain.Model
{
    public class User
    {
        public int UserId { get; private set; }
        public string? UserName { get; private set; }
        public string Email { get; private set; }
        public Password Password { get; private set; }
        public ushort LoginAttemps { get; private set; }
        public string Role { get; private set; }
        public Citizen? Citizen { get; private set; }
        public Address? Address { get; private set; }

#pragma warning disable CS8618 // EF constructor
        private User() { }
#pragma warning restore CS8618 // EF constructor
        public User(string userName, string email, Password password, string role = "citizen")
        {
            UserName = userName;
            Role = role;
            Email = email;
            Password = password;
        }

        public void ChangePassword(Password password)
        { 
            Password = password;
        }
    }
}
