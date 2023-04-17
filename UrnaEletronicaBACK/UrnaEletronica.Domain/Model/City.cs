namespace UrnaEletronica.Domain.Model
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public State? State { get; set; }
        public ICollection<Address>? Addresses { get; set; }

        public City(string cityName)
        {
            CityName = cityName;
        }
    }
}
