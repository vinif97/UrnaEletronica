namespace UrnaEletronica.Domain.Model
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public short Number { get; set; }
        public string? Complement { get; set; }
        public string? Reference { get; set; }
        public string Zipcode { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public City? City { get; set; }

        public Address(string streetAddress, short number, string? complement, string zipcode)
        {
            StreetAddress = streetAddress;
            Number = number;
            Complement = complement;
            Zipcode = zipcode;
        }
    }
}
