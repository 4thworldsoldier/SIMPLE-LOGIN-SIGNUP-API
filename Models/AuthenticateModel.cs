using System.ComponentModel.DataAnnotations;

namespace SIMPLE_LOGIN_SIGNUP_API.Models
{
    public class AuthenticateModel
    {
        //[Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}