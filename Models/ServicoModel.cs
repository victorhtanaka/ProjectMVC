using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Servico
    {
        [Key]
        public int CodServico { get; set; }

        [Required]
        [StringLength(50)]
        public string NomeServico { get; set; }

        [StringLength(100)]
        public string DescServico { get; set; }
    }
}