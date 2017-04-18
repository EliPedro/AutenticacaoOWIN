using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OwinAuthentication.Models
{
    [Table("Usuario", Schema ="dbo")]
    public class Usuario : IUser<int>
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; } 

        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "*")]
        [Column("UserName")]
        public string UserName { get; set; }
        
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "*")]
        [Column("Senha")]
        public string Senha { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirma senha", Prompt = "Confirma senha")]
        [Required(ErrorMessage = "*")]
        [Compare("Senha")]
        public string ConfirmaSenha { get; set; }
        
    }
}