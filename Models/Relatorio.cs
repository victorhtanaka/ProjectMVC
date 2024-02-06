using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Relatorio
    {
        [Key]
        public int CodRelatorio { get; set; }

        public decimal Valor { get; set; }

        [Required(ErrorMessage="A descricao do relatorio nao pode ser vazia.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "A descricao do relatorio deve possuir no minimo 1 e no maximo 200 caracteres.")]
        public string? DescRelatorio { get; set; }

        [ForeignKey("Agenda")]
        public int FkAgendaCodAgenda { get; set; }
    }
}