using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class AdminInfo
    {
        [Key]
        [StringLength(30)]
        public string? LoginAdmin { get; set; }

        [StringLength(30)]
        public string? SenhaAdmin { get; set; }

        public bool RememberMe { get; internal set; }

        [ForeignKey("Filial")]
        public int FkFilialCodFilial { get; set; }
    }
}