using Microsoft.AspNetCore.Identity;

namespace crowdfunding.Data
{
    public class User : IdentityUser
    {
        public string PhotoPath { get; set; }
    }
}
