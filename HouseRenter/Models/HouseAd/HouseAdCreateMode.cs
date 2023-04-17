using HouseRenter.Data.Entities;

namespace HouseRenter.Models.HouseAd
{
    public class HouseAdCreateMode
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int BrokerId { get; set; }

        public Broker Broker { get; set; }

        public DateTime YearCreated { get; set; }

        public decimal Price { get; set; }

        public string Location { get; set; }

        public HeatingType Heating { get; set; }
    }
}
