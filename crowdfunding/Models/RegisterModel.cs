using Microsoft.AspNetCore.Http;

namespace crowdfunding.Models
{
    public class RegisterModel
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public IFormFile Photo { get; set; }
    }
}