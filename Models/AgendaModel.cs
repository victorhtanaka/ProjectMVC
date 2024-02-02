using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Agenda
    {
        [Key]
        public int CodAgenda { get; set; }

        public DateTime DataAgenda { get; set; }

        [StringLength(50)]
        public string Modelo { get; set; }

        public int Ano { get; set; }

        public float Km { get; set; }

        [ForeignKey("Funcionario")]
        public int FkFuncionarioCodFuncionario { get; set; }

        [ForeignKey("Servico")]
        public int FkServicoCodServico { get; set; }

        [ForeignKey("Cliente")]
        public int FkClienteCodCliente { get; set; }
    }
}