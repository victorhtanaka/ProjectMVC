using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Funcao
    {
        [Key]
        public int CodFuncao { get; set; }

        [Required(ErrorMessage="O nome nao pode ser vazio.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "O nome deve possuir no minimo 1 e no maximo 30 caracteres.")]
        public string? NomeFuncao { get; set; }

        [Required(ErrorMessage="A descrição nao pode ser vazia.")]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "A descrição deve possuir no minimo 1 e no maximo 150 caracteres.")]
        public string? DescricaoFuncao { get; set; }
    }
}
