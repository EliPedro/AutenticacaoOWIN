using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OwinAuthentication.Models
{
    [Table("Usuario", Schema ="dbo")]
    public class Usuario : IUser<string>
    {
        public string Id { get; set; } 

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*")]
        public string UserName { get; set; }
     
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "*")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirma senha")]
        [Required(ErrorMessage = "*")]
        [Compare("Senha")]
        public string ConfrimaSenha { get; set; }
        
    }
}