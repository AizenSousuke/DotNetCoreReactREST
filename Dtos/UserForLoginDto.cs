using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Dtos
{
    public class UserForLoginDto
    {
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Hmmm that doesn't look like a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please type a password")]
        public string PasswordHash { get; set; }
    }
}
