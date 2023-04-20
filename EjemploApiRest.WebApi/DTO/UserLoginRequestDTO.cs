using System.ComponentModel.DataAnnotations;

namespace EjemploApiRest.WebApi.DTO
{
    public class UserLoginRequestDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
