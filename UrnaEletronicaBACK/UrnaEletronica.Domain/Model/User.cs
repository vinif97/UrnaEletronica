using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Domain.ValueObject;

namespace UrnaEletronica.Domain.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public Password? Password { get; set; }
        public ushort LoginAttemps { get; set; }
        public string Role { get; set; }
        public Citizen? Citizen { get; set; }
        public Address? Address { get; set; }

        public User(string userName, string role = "citizen")
        {
            UserName = userName;
            Role = role;
        }
    }
}
