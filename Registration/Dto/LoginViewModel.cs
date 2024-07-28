using System.ComponentModel.DataAnnotations;

namespace Registration.Dto
{
    public class LoginViewModel
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
