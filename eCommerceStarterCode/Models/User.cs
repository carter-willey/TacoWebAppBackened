using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public bool IsOwner { get; set; }
        public bool HasLogged { get; set; }

    }
}
