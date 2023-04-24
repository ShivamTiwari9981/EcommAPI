using System.ComponentModel.DataAnnotations;

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
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Mobile { get; set; }
        public string Type { get; set; }
    }
}
