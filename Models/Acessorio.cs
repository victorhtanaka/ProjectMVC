using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Acessorio
    {
        [Key]
        public int CodAcessorio { get; set; }

        [Required(ErrorMessage="O nome do acessorio nao pode ser vazio.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve possuir no minimo 3 e no maximo 50 caracteres")]
        public string? NomeAcessorio { get; set; }
    }
}