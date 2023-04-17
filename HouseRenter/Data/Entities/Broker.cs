namespace HouseRenter.Data.Entities
{
    public class Broker
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public ICollection<HouseAd> HouseAds { get; set; } = new List<HouseAd>();
    }
}