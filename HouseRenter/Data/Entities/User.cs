using Microsoft.AspNetCore.Identity;

namespace HouseRenter.Data.Entities
{
    public class User : IdentityUser
    {
        public Broker Broker { get; set; }
    }
}