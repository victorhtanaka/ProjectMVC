using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Acessorio
    {
        [Key]
        public int CodAcessorio { get; set; }

        [Required]
        [StringLength(50)]
        public string? NomeAcessorio { get; set; }
    }
}