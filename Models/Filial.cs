using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Filial
    {
        [Key]
        public int CodFilial { get; set; }

        [Required]
        [StringLength(100)]
        public string? NomeFilial { get; set; }

        [Required]
        [StringLength(200)]
        public string? EndFilial { get; set; }

        [Required]
        [StringLength(15)]
        public string? TelFilial { get; set; }
    }
}