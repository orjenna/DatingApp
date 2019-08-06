using System.ComponentModel.DataAnnotations;

namespace Dating.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage="Password must be more than 4 less than 8")]
        public string password { get; set; }
    }
}