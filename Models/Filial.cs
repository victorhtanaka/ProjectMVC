using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Filial
    {
        [Key]
        public int CodFilial { get; set; }

        [Required(ErrorMessage="O nome nao pode ser vazio.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome deve possuir no minimo 1 e no maximo 100 caracteres.")]
        public string? NomeFilial { get; set; }

        [Required(ErrorMessage="O endereço nao pode ser vazio.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "O endereço deve possuir no minimo 1 e no maximo 200 caracteres.")]
        public string? EndFilial { get; set; }

        [Required(ErrorMessage="O telefone nao pode ser vazio.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "O telefone deve possuir no minimo 1 e no maximo 15 caracteres.")]
        public string? TelFilial { get; set; }
    }
}