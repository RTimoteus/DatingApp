using System.ComponentModel.DataAnnotations;

namespace datingapp.api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 8, ErrorMessage = "Pasword should be at least 8 characters long")]
        public string Password { get; set; }
    }
}