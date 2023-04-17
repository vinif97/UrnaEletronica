using UrnaEletronica.Domain.ValueObject;

namespace UrnaEletronica.Domain.Model
{
    public class Citizen
    {
        public int CitizenId { get; set; }
        public CitizenIdentity CitizenIdentity { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }

        public Citizen(CitizenIdentity citizenIdentity)
        { 
            CitizenIdentity = citizenIdentity;
        }


    }
}
