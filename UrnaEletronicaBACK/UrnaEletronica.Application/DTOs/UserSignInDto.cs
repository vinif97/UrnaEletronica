using System.ComponentModel.DataAnnotations;

namespace UrnaEletronica.Application.DTOs
{
    public class UserSignInDto
    {
        [Required(ErrorMessage = "Email cannot be empty")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password cannot be empty")]
        public string? Password { get; set; }
    }
}
