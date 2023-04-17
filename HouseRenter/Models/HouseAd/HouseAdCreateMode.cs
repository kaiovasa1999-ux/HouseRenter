using HouseRenter.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace HouseRenter.Models.HouseAd
{
    using static Data.DatabaseConstants.HouseAdConstants;

    public class HouseAdCreateMode
    {
        [Required]
        [MinLength(LocationMinLength)]
        [MaxLength(LocationMaxLength)]
        public string Location { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required]
        [Display(Name = "Year Created")]
        [Range(minYearCreate, maxYearCreate)]
        public DateTime YearCreated { get; set; }

        [Required]
        [Range(MinPrice,MaxPrice)]
        public decimal Price { get; set; }


        [EnumDataType(typeof(HouseAdCreateMode))]
        public HeatingType Heating { get; set; }
    }
}
