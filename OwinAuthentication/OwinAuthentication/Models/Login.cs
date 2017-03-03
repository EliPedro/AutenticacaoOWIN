using System.ComponentModel.DataAnnotations.Schema;

namespace OwinAuthentication.Models
{
    [NotMapped]
    public class Login
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}