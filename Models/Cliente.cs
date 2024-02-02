using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Cliente
    {
        [Key]
        public int CodCliente { get; set; }

        [Required]
        [StringLength(100)]
        public string? NomeCliente { get; set; }

        [StringLength(15)]
        public string? CPFCliente { get; set; }

        [StringLength(200)]
        public string? EndCliente { get; set; }

        [StringLength(150)]
        public string? EmailCliente { get; set; }

        [StringLength(15)]
        public string? TelCliente { get; set; }

        public DateOnly DataNasc { get; set; }
    }
}