using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Servico
    {
        [Key]
        public int CodServico { get; set; }

        [Required(ErrorMessage="O nome do serviço nao pode ser vazio.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O nome do serviço deve possuir no minimo 1 e no maximo 50 caracteres.")]
        public string? NomeServico { get; set; }

        [Required(ErrorMessage="A descrição nao pode ser vazia.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "A descrição deve possuir no minimo 1 e no maximo 100 caracteres.")]
        public string? DescServico { get; set; }
    }
}