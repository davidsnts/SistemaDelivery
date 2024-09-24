using System.ComponentModel.DataAnnotations;

namespace SistemaDeliveryWeb.Models.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Campo Nome obrigatório")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Campo Telefone obrigatório")]
        [Phone(ErrorMessage ="Telefone inválido")]
        public required string Telefone { get; set; }

        [Required(ErrorMessage = "Campo e-mail obrigatório")]
        [EmailAddress(ErrorMessage ="E-mail inválido")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Campo senha obrigatório")]
        [MinLength(8,ErrorMessage ="A senha deve ter no minimo 8 digitos")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Confirme a senha")]
        [Compare("Password", ErrorMessage ="As senhas não são iguais")]
        public required string ConfirmPassword { get; set; }

    }
}
