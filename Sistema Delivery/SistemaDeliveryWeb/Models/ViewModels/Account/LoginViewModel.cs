using System.ComponentModel.DataAnnotations;

namespace SistemaDeliveryWeb.Models.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Campo e-mail obrigatório")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "Campo senha obrigatório")]
        public required string Password { get; set; }
        public bool RememberMe { get; set; } = false;

    }
}
