using System.ComponentModel.DataAnnotations;

namespace DotNetCoreReactREST.Dtos
{
    public class UserForLoginDto : UserDto
    {
        [Required]
        public new string Email { get; set; }

        [Required]
        public new string PasswordHash { get; set; }
    }
}