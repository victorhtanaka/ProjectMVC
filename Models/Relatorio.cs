using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Relatorio
    {
        [Key]
        public int CodRelatorio { get; set; }

        public decimal Valor { get; set; }

        [StringLength(200)]
        public string? DescRelatorio { get; set; }

        [ForeignKey("Agenda")]
        public int FkAgendaCodAgenda { get; set; }
    }
}