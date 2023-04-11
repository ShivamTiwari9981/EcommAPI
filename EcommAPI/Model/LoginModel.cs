using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace EcommAPI.Model
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
    public class LoginResponseModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Mobile { get; set; }
        public string Type { get; set; }
    }
}
