using System.Text.RegularExpressions;

namespace HouseRenter.Data
{
    public class DatabaseConstants
    {
        public class HouseAdConstants
        {
            public const int MinPrice = 0;
            public const int MaxPrice = 1000_000_000;
            public const int LocationMinLength = 3;
            public const int LocationMaxLength = 300;
            public const int minYearCreate = 1800;
            public const int maxYearCreate = 2030;
            public DateTime YearCreatedMaxDate = new DateTime(2025, 1, 1);
        }

        public class CategoryConstatns
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
            public const int DescriptionMinLength = 5;
            public const int DescriptionMaxLength = 1000;
        }

        public class BrokerConstants
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
            public const string PhoneNmberRequirements = @"\+[0-9]*";
        }
    }
}
