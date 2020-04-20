using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserRegisterDto
    {
        [Required]
        public string  Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password must be min length of 4 and max of 8 characters" )]
        public string  Password { get; set; }
    }
}