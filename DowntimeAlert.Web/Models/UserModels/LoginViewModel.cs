using System.ComponentModel.DataAnnotations;

namespace DowntimeAlert.Web.Models.UserModels
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
