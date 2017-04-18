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

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Campo obrigátorio")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
    }
}