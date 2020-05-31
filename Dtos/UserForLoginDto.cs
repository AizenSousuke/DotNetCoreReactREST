using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public string Token { get; set; }
    }
}