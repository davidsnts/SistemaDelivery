using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeliveryWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Phone]
        public string Telefone { get; set; }
    }
}
