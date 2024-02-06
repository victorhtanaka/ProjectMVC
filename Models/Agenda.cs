using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Agenda
    {
        [Key]
        public int CodAgenda { get; set; }

        public DateTime DataAgenda { get; set; }

        [Required(ErrorMessage="O modelo nao pode ser vazio.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O modelo deve possuir no minimo 1 e no maximo 50 caracteres.")]
        public string? Modelo { get; set; }

        [Required(ErrorMessage="O ano nao pode ser vazio.")]
        [Range(4, 4, ErrorMessage="O ano deve ter 4 numeros.")]  
        public int Ano { get; set; }

        [Required(ErrorMessage="A quilometragem nao pode ser vazia")]
        public float Km { get; set; }

        [ForeignKey("Funcionario")]
        public int FkFuncionarioCodFuncionario { get; set; }

        [ForeignKey("Servico")]
        public int FkServicoCodServico { get; set; }

        [ForeignKey("Cliente")]
        public int FkClienteCodCliente { get; set; }
    }
}