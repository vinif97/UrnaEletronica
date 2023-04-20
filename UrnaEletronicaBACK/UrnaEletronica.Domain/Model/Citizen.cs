using UrnaEletronica.Domain.ValueObject;

namespace UrnaEletronica.Domain.Model
{
    public class Citizen
    {
        public int CitizenId { get; set; }
        public CitizenIdentity CitizenIdentity { get; private set; }
        public int UserId { get; set; }
        public User? User { get; set; }

#pragma warning disable CS8618 // EF constructor
        private Citizen() { }
#pragma warning restore CS8618 // EF constructor
        public Citizen(CitizenIdentity citizenIdentity)
        { 
            CitizenIdentity = citizenIdentity;
        }
    }
}
