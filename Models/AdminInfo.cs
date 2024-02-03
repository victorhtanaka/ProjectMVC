using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class AdminInfo
    {
        [Key]
        public int CodAdmin { get; set; }

        [Required]
        [StringLength(30)]
        public string? LoginAdmin { get; set; }

        [StringLength(30)]
        public string? SenhaAdmin { get; set; }

        [ForeignKey("Filial")]
        public int FkFilialCodFilial { get; set; }
    }
}