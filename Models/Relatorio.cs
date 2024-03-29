using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Relatorio
    {
        [Key]
        public int CodRelatorio { get; set; }

        [Required(ErrorMessage="O valor nao pode ser vazio")]
        [Range(0, 999999.99, ErrorMessage="O valor deve ser entre 0 e 999999.99.")]  
        public decimal Valor { get; set; }

        [Required(ErrorMessage="A descricao do relatorio nao pode ser vazia.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "A descricao do relatorio deve possuir no minimo 1 e no maximo 200 caracteres.")]
        public string? DescRelatorio { get; set; }

        [ForeignKey("Agenda")]
        public int FkAgendaCodAgenda { get; set; }
    }
}