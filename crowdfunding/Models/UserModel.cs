using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace crowdfunding.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
