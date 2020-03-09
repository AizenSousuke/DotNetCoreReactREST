using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Dtos.User
{
    public abstract class UserForManipulationDto
    {
        [Required]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Don't forget to fill out your email")]
        [EmailAddress(ErrorMessage = "Hmmm that doesn't look like a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please type a password")]
        public string PasswordHash { get; set; }

        [Required]
        public bool IsAdmin { get; set; }
    }
}
