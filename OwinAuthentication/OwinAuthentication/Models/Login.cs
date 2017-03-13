using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OwinAuthentication.Models
{
    [NotMapped]
    public class Login
    {
        [Required(ErrorMessage = "Campo obrigátorio")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigátorio")]
        public string Senha { get; set; }
    }
}